using GraphicsEditor.Engine;
using GraphicsEditor.Serialization;
using System.Text;
using System.Xml;
using Newtonsoft.Json;

namespace XmlTransformPlugin
{
    public class XmlTransformPlugin : Plugin
    {
        public XmlTransformPlugin()
        {

        }

        public override string Name()
        {
            return "XmlTransformPlugin";
        }

        public override string Description()
        {
            return "Provides the ability to transform xml to json";
        }

        public override int Order()
        {
            return 1;
        }

        public override byte[] ProcessDataOnSave(string path, SerializationFormat serializationFormat, byte[] data)
        {
            if(SerializationFormat.XML == serializationFormat)
            {
                string xmlStr = Encoding.UTF8.GetString(data);

                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlStr);

                string jsonStr = 
                    JsonConvert.SerializeXmlNode(xmlDocument, Newtonsoft.Json.Formatting.None, true);

                return Encoding.UTF8.GetBytes(jsonStr);
            }

            return data;
        }

        public override byte[] ProcessDataOnLoad(string path, SerializationFormat serializationFormat, byte[] data)
        {
            if(SerializationFormat.XML == serializationFormat)
            {
                string jsonStr = Encoding.UTF8.GetString(data);

                string xmlStr = JsonConvert.DeserializeXNode(jsonStr, "SOAP-ENV:Envelope").ToString();

                return Encoding.UTF8.GetBytes(xmlStr);
            }

            return data;
        }

    }
}
