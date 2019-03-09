using System.Collections.Generic;
using System.Drawing;
using System;

namespace GraphicsEditor.Shapes
{
    class Rectangle : FilledShape
    {
        protected int length;
        protected int width;

        public Rectangle()
        {

        }

        public Rectangle(Point point1, Point point2, Color penColor, Color brushColor)
            : base(new List<Point>() { point1, point2 }, penColor, brushColor)
        {
            this.length = Math.Abs(point1.X - point2.X);
            this.width = Math.Abs(point1.Y - point2.Y);
        }

        public override int DefiningPointsCount()
        {
            return 2;
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
    }
}
