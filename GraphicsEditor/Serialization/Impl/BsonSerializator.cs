using System.IO;
//using MongoDB.Bson;
//using MongoDB.Bson.IO;
//using MongoDB.Bson.Serialization.Options;
//using MongoDB.Bson.Serialization.Conventions;
//using MongoDB.Bson.Serialization.Attributes;
//using MongoDB;
//using MongoDB.Driver.GeoJsonObjectModel;
//using MongoDB.Bson.Serialization;

//using MongoDB.Bson.Serialization.Serializers;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

namespace GraphicsEditor.Serialization
{
    class BsonSerializator : ISerializator
    {
        private static BsonSerializator instance;

        private JsonSerializer serializer;

        private BsonSerializator()
        {
            serializer = new Newtonsoft.Json.JsonSerializer();
            serializer.Converters.Add(new Newtonsoft.Json.Converters.JavaScriptDateTimeConverter());
            serializer.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            serializer.TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto;
            serializer.Formatting = Newtonsoft.Json.Formatting.Indented;
        }

        public static BsonSerializator getInstance()
        {
            if (instance == null)
                instance = new BsonSerializator();
            return instance;
        }

        public SerializationFormat OutputFormat()
        {
            return SerializationFormat.BSON;
        }

        public void Serialize<T>(Stream stream, T obj)
        {
            using (BsonWriter writer = new BsonWriter(stream))
            {
                writer.CloseOutput = false;
                serializer.Serialize(writer, obj, typeof(T));
            }
        }

        public T Deserialize<T>(Stream stream)
        {
            using (BsonReader reader = new BsonReader(stream))
            {
                reader.CloseInput = false;
                return serializer.Deserialize<T>(reader);
            }
        }
    }
}
