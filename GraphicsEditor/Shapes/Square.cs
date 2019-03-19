using System;
using System.Drawing;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GraphicsEditor.Shapes
{
    [Serializable]
    [XmlRoot]
    public class Square : Rectangle
    {
        public Square(string typeName, Point[] points, Color color) 
            : base(typeName, points, color)
        {
            this.Height = Math.Min(this.Height, this.Width);
            this.Width = this.Height;
        }
    }
}
