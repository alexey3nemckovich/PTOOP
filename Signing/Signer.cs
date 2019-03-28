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

        }

        public static Signer getInstance()
        {
            if (instance == null)
                instance = new Signer();
            return instance;
        }

        public SigningStatus CheckSignatureForFile(string filePath)
        {
            string signatureFilePath = GetSignatureFilePath(filePath);

            if (File.Exists(signatureFilePath))
            {
                Signature storedSignature = ReadSignature(signatureFilePath);
                Signature actualSignature = CalcSignature(filePath);

                if(storedSignature.Equals(actualSignature))
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
            string signatureFilePath = GetSignatureFilePath(filePath);

            File.WriteAllText(signatureFilePath, signatureStr);

            return true;
        }

        private string GetSignatureFilePath(string filePath)
        {
            string folderPath = Path.GetDirectoryName(filePath);
            return folderPath + "\\.sig";
        }

        private Signature ReadSignature(string signatureFilePath)
        {
            string text = File.ReadAllText(signatureFilePath, Encoding.UTF8);
            return Serializer.Deserialize<Signature>(text);
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
