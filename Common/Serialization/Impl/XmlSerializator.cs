using System.IO;
using System.Runtime.Serialization.Formatters.Soap;


namespace GraphicsEditor.Serialization
{
    class XmlSerializator : ISerializator
    {
        private static XmlSerializator instance;

        private SoapFormatter formatter = new SoapFormatter();

        private XmlSerializator()
        {

        }

        public static XmlSerializator getInstance()
        {
            if (instance == null)
                instance = new XmlSerializator();
            return instance;
        }

        public SerializationFormat OutputFormat()
        {
            return SerializationFormat.XML;
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
