using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace Signing
{
    public enum SigningStatus
    {
        NOT_SIGNED,
        VALIID_SIGNATURE,
        INVALID_SIGNATURE
    }

    public class Signer
    {
        private static Signer instance;

        private Signer()
        {
            CryptingSignature = true;
        }

        public static Signer getInstance()
        {
            if (instance == null)
                instance = new Signer();
            return instance;
        }

        public bool CryptingSignature { get; set; }

        public SigningStatus CheckSignatureForFile(string filePath)
        {
            string signatureFilePath = GetSignatureFilePath(filePath);

            if (File.Exists(signatureFilePath))
            {
                Signature actualSignature = CalcSignature(filePath);
                Signature storedSignature = ReadSignature(signatureFilePath);

                if(actualSignature.Equals(storedSignature))
                {
                    return SigningStatus.VALIID_SIGNATURE;
                }
                else
                {
                    return SigningStatus.INVALID_SIGNATURE;
                }
            }
            else
            {
                return SigningStatus.NOT_SIGNED;
            }
        }

        public bool SignFile(string filePath)
        {
            Signature signature = CalcSignature(filePath);

            string signatureStr = Serializer.Serialize(signature);
            byte[] signatureBytes = Encoding.UTF8.GetBytes(signatureStr);

            if(CryptingSignature)
            {
                signatureBytes = ProtectedData.Protect(signatureBytes, null, DataProtectionScope.LocalMachine);
            }

            string signatureFilePath = GetSignatureFilePath(filePath);

            File.WriteAllBytes(signatureFilePath, signatureBytes);
            return true;
        }

        private Signature ReadSignature(string signatureFilePath)
        {
            try
            {
                byte[] signatureBytes = File.ReadAllBytes(signatureFilePath);

                if(CryptingSignature)
                {
                    signatureBytes = ProtectedData.Unprotect(signatureBytes, null, DataProtectionScope.LocalMachine);
                }
                
                string signatureStr = Encoding.UTF8.GetString(signatureBytes);
            
                return Serializer.Deserialize<Signature>(signatureStr);
            }
            catch(Exception e)
            {
                return null;
            }
        }

        private string GetSignatureFilePath(string filePath)
        {
            string folderPath = Path.GetDirectoryName(filePath);
            return folderPath + "\\.sig";
        }

        private Signature CalcSignature(string filePath)
        {
            Signature signature = new Signature();

            signature.Hash = GetHash(filePath);
            signature.Date = File.GetCreationTime(filePath);

            return signature;
        }

        private byte[] GetHash(string path)
        {
            FileStream stream = File.OpenRead(path);
            SHA256Managed sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(stream);
            return hash;
        }
    }
}
