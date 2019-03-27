using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using GraphicsEditor.Common;

namespace GraphicsEditor.Shapes
{
    [DataContract]
    [Serializable]
    [XmlRoot]
    public abstract class Shape
    {
        public Shape()
        {

        }

        public Shape(string typeName, Point[] points, Color color)
        {
            this.TypeName = typeName;
            this.Points = points;
            this.Color = color;
        }

        [DataMember]
        [XmlElement]
        public string TypeName { get; set; }

        [DataMember]
        [XmlElement]
        public Point[] Points { get; set; }

        [DataMember]
        [XmlElement(Type = typeof(XmlColor))]
        public Color Color { get; set; }

    }
}
