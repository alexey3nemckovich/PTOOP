using System.Collections.Generic;
using System.Linq;

namespace GraphicsEditor.Serialization
{
    public class SerializationManager
    {
        private static SerializationManager instance;

        private Dictionary<SerializationFormat, ISerializator> serialozators;

        private SerializationManager()
        {
            serialozators = new Dictionary<SerializationFormat, ISerializator>();

            RegisterSerializator(BinarySerializator.getInstance());
            RegisterSerializator(BsonSerializator.getInstance());
            RegisterSerializator(JsonSerializator.getInstance());
            RegisterSerializator(XmlSerializator.getInstance());
        }

        public static SerializationManager getInstance()
        {
            if (instance == null)
                instance = new SerializationManager();
            return instance;
        }

        public List<SerializationFormat> GetSupportedFormats()
        {
            return serialozators.Keys.ToList();
        }

        public ISerializator GetSerializatorForFormat(SerializationFormat format)
        {
            if(serialozators.ContainsKey(format))
            {
                return serialozators[format];
            }
            else
            {
                return null;
            }
        }

        private void RegisterSerializator(ISerializator serializator)
        {
            serialozators[serializator.OutputFormat()] = serializator;
        }
    }
}
