using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace GraphicsEditor.Serialization
{
    class BinarySerializator : ISerializator
    {
        private static BinarySerializator instance;

        private BinaryFormatter formatter = new BinaryFormatter();

        private BinarySerializator()
        {

        }

        public static BinarySerializator getInstance()
        {
            if (instance == null)
                instance = new BinarySerializator();
            return instance;
        }

        public SerializationFormat OutputFormat()
        {
            return SerializationFormat.Binary;
        }

        public void Serialize<T>(Stream stream, T obj)
        {
            formatter.Serialize(stream, obj);
        }
        
        public T Deserialize<T>(Stream stream)
        {
            return (T)formatter.Deserialize(stream);
        }
    }
}
