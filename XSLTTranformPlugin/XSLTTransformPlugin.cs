using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsEditor.Engine;
using GraphicsEditor.Serialization;
using System.Xml.Xsl;

namespace XSLTTranformPlugin
{
    public class XSLTTransformPlugin : Plugin
    {
        public XSLTTransformPlugin()
        {
            //RegisterParameter(
            //    "Additional entropy",
            //    delegate (string strValue)
            //    {
            //        return strValue;
            //    },
            //    "");
        }

        public override string Name()
        {
            return "XSLTTransformPlugin";
        }

        public override string Description()
        {
            return "Provides the ability to transform xml to xslt";
        }

        public override int Order()
        {
            return 1;
        }

        public override byte[] ProcessDataOnSave(SerializationFormat serializationFormat, byte[] data)
        {
            if (SerializationFormat.XML == serializationFormat)
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

        public override byte[] ProcessDataOnLoad(SerializationFormat serializationFormat, byte[] data)
        {
            if (SerializationFormat.XML == serializationFormat)
            {
                string xsltStr = Encoding.UTF8.GetString(data);

                XslTransform xslTransform = new XslTransform();

                string jsonStr = Encoding.UTF8.GetString(data);

                string xmlStr = JsonConvert.DeserializeXNode(jsonStr, "SOAP-ENV:Envelope").ToString();

                return Encoding.UTF8.GetBytes(xmlStr);
            }

            return data;
        }

    }
}
