using GraphicsEditor.Engine;
using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using GraphicsEditor.Serialization;
using GraphicsEditor.Common;

namespace ArchivingPlugin
{
    public class ArchivingPlugin : Plugin
    {

        private static string compressionLevelParamName = "Compression level";

        public ArchivingPlugin()
        {
            Array array = Enum.GetValues(typeof(CompressionLevel));
            HashSet<string> values = new HashSet<string>();
            foreach (var value in array)
            {
                values.Add(value.ToString());
            }

            RegisterParameter(
                compressionLevelParamName,
                CompressionLevel.Fastest,
                values,
                delegate (string strVal)
                {
                    return Enum.Parse(typeof(CompressionLevel), strVal);
                });
        }

        public override string Name()
        {
            return "ArchivingPlugin";
        }

        public override string Description()
        {
            return "Provides the ability to archive file";
        }

        public override int Order()
        {
            return 2;
        }

        public override byte[] ProcessDataOnSave(string path, SerializationFormat serializationFormat, byte[] data)
        {
            using (MemoryStream targetStream = new MemoryStream())
            {
                using (
                    DeflateStream compressionStream =
                        new DeflateStream(
                            targetStream,
                            (CompressionLevel)ParametersInfo[compressionLevelParamName].Value))
                {
                    compressionStream.Write(data, 0, data.Length);
                }

                return targetStream.ToArray();
            }
        }

        public override byte[] ProcessDataOnLoad(string path, SerializationFormat serializationFormat, byte[] data)
        {
            using (MemoryStream targetStream = new MemoryStream(data))
            {
                using (
                    DeflateStream compressionStream =
                        new DeflateStream(
                            targetStream,
                            CompressionMode.Decompress))
                {
                    return Utils.ReadStream(compressionStream);
                }
            }
        }

    }
}
