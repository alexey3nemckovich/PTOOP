using System.IO;

namespace GraphicsEditor.Serialization
{
    interface ISerializator
    {
        SerializationFormat OutputFormat();

        void Serialize<T>(Stream stream, T obj);

        T Deserialize<T>(Stream stream);
    }
}
