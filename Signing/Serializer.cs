using Newtonsoft.Json;

namespace Signing
{
    public class Serializer
    {
        public static string Serialize(object smth)
        {
            return JsonConvert.SerializeObject(smth);
        }

        public static T Deserialize<T>(string smth)
        {
            return JsonConvert.DeserializeObject<T>(smth);
        }
    }
}
