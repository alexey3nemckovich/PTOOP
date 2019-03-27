using System.IO;
using Newtonsoft.Json;


namespace GraphicsEditor.Serialization
{
    class JsonSerializator : ISerializator
    {
        private static JsonSerializator instance;

        private JsonSerializerSettings settings;

        private JsonSerializator()
        {
            settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
        }

        public static JsonSerializator getInstance()
        {
            if (instance == null)
                instance = new JsonSerializator();
            return instance;
        }

        public SerializationFormat OutputFormat()
        {
            return SerializationFormat.JSON;
        }

        private static int bufferSize = 10000;

        public void Serialize<T>(Stream stream, T obj)
        {
            using (StreamWriter streamWriter = new StreamWriter(stream, System.Text.Encoding.Default, bufferSize, true))
            {
                string json = JsonConvert.SerializeObject(obj, settings);
                streamWriter.Write(json);
            }
        }

        public T Deserialize<T>(Stream stream)
        {
            using (StreamReader streamReader = new StreamReader(stream, System.Text.Encoding.Default, false, bufferSize, true))
            {
                string json = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(json, settings);
            }
        }
    }
}
