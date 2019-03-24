using System;
using System.Drawing;
using System.Xml.Serialization;

namespace GraphicsEditor.Shapes
{
    [Serializable]
    [XmlRoot]
    public class Line : Shape
    {
        public Line()
        {

        }

        public Line(string typeName, Point[] points, Color color):
            base(typeName, points, color)
        {

        }
    }
}
