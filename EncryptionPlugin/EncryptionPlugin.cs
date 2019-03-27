using System;
using System.Collections.Generic;
using GraphicsEditor.Engine;
using System.Security.Cryptography;
using GraphicsEditor.Serialization;
using System.Text;

namespace EncryptionPlugin
{
    public class EncryptionPlugin : Plugin
    {

        private static string additionalEntropyParamName = "Additional entropy";
        private static string protectionScopeParamName = "Protection scope";

        public EncryptionPlugin()
        {
            RegisterParameter(
                additionalEntropyParamName, 
                null,
                delegate (string strValue)
                {
                    if(0 == strValue.Length)
                    {
                        return null;
                    }

                    return Encoding.UTF8.GetBytes(strValue);
                },
                delegate (object value)
                {
                    if(null == value)
                    {
                        return "";
                    }

                    return Encoding.UTF8.GetString((byte[])value);
                });

            Array array = Enum.GetValues(typeof(DataProtectionScope));
            HashSet<string> values = new HashSet<string>();
            foreach(var value in array)
            {
                values.Add(value.ToString());
            }

            RegisterParameter(
                protectionScopeParamName,
                DataProtectionScope.CurrentUser,
                values,
                delegate (string strVal)
                {
                    return Enum.Parse(typeof(DataProtectionScope), strVal);
                });
        }

        public override string Name()
        {
            return "EncryptionPlugin";
        }

        public override string Description()
        {
            return "Provides the ability to encrypt data";
        }

        public override int Order()
        {
            return 1;
        }

        public override byte[] ProcessDataOnSave(string path, SerializationFormat serializationFormat, byte[] data)
        {
            return 
                ProtectedData.Protect(
                    data,
                    (byte[])ParametersInfo[additionalEntropyParamName].Value,
                    (DataProtectionScope)ParametersInfo[protectionScopeParamName].Value);
        }

        public override byte[] ProcessDataOnLoad(string path, SerializationFormat serializationFormat, byte[] data)
        {
            return
                ProtectedData.Unprotect(
                    data,
                    (byte[])ParametersInfo[additionalEntropyParamName].Value,
                    (DataProtectionScope)ParametersInfo[protectionScopeParamName].Value);
        }

    }
}
