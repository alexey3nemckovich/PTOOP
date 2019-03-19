using System.Collections.Generic;
using System.Drawing;
using System;
using System.Xml.Serialization;

namespace GraphicsEditor.Shapes
{
    [Serializable]
    [XmlRoot]
    public class Rectangle : Shape
    {
        private int width;
        private int height;

        public Rectangle()
        {

        }

        public Rectangle(string typeName, Point[] points, Color color)
            : base(typeName, points, color)
        {
            this.width = Math.Abs(Points[0].X - Points[1].X);
            this.height = Math.Abs(Points[0].Y - Points[1].Y);
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }
    }
}
