using System.Drawing;
using System;
using System.Xml.Serialization;

namespace GraphicsEditor.Shapes
{
    [Serializable]
    [XmlRoot]
    public class Triangle : Shape
    {        
        public Triangle()
        {

        }

        public Triangle(string typeName, Point[] points, Color color)
            : base(typeName, points, color)
        {

        }
    }
}
