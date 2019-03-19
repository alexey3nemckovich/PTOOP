using System;
using System.Drawing;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GraphicsEditor.Shapes
{
    [Serializable]
    [XmlRoot]
    public class Circle : Ellipse
    {
        public Circle(string typeName, Point[] points, Color color)
            : base(typeName, points, color)
        {
            this.Width = Math.Min(this.Height, this.Width);
            this.Height = this.Width;
        }
    }
}
