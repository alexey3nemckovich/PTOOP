using System.Collections.Generic;
using System.Drawing;
using System;

namespace GraphicsEditor.Shapes
{
    class Rectangle : Shape
    {
        private int width;
        private int height;

        public Rectangle()
        {

        }

        public Rectangle(string typeName, List<Point> points, Color penColor, Color brushColor)
            : base(typeName, points, penColor, brushColor)
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
