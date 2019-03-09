using System;
using System.Drawing;
using System.Collections.Generic;

namespace GraphicsEditor.Shapes
{
    class Ellipse : FilledShape
    {
        protected int length;
        protected int width;

        public Ellipse()
        {

        }

        public Ellipse(Point point1, Point point2, Color brushColor, Color penColor)
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
