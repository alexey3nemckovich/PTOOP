using GraphicsEditor.Engine;
using GraphicsEditor.Serialization;
using System.Collections.Generic;
using GraphicsEditor;

namespace CheckSumPlugin
{
    public class CheckSumPlugin : Plugin
    {

        public CheckSumPlugin()
        {

        }

        public override string Name()
        {
            return "CheckSumPlugin";
        }

        public override string Description()
        {
            return "Provides the ability to verify the file through checksum verification";
        }

        public override int Order()
        {
            return 0;
        }

        private byte[] CalculateCheckSum(byte[] data)
        {
            byte[] checkSum;

            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                md5.TransformFinalBlock(data, 0, data.Length);
                checkSum = md5.Hash;
            }

            return checkSum;
        }

        private Dictionary<string, byte[]> filesCheckSumDictionary = new Dictionary<string, byte[]>();

        public override byte[] ProcessDataOnSave(string path, SerializationFormat serializationFormat, byte[] data)
        {
            filesCheckSumDictionary[path] = CalculateCheckSum(data);

            return data;
        }

        public override byte[] ProcessDataOnLoad(string path, SerializationFormat serializationFormat, byte[] data)
        {
            byte[] fileCheckSum = CalculateCheckSum(data);

            if(filesCheckSumDictionary.ContainsKey(path))
            {
                if(!Utils.ByteArraysEquals(filesCheckSumDictionary[path], fileCheckSum))
                {
                    throw new InvalidFileCheckSumException("Invalid check sum for file '" + path + "'.");
                }
            }

            return data;
        }

    }
}
