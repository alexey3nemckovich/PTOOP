using System;
using System.Drawing;
using System.Collections.Generic;

namespace GraphicsEditor.Shapes
{
    class Ellipse : Shape
    {
        private int width;
        private int height;

        public Ellipse()
        {

        }

        public Ellipse(List<Point> points, Color penColor, Color brushColor)
            : base(points, penColor, brushColor)
        {
            this.width = Math.Abs(Points[0].X - Points[1].X);
            this.height = Math.Abs(Points[0].Y - Points[1].Y);
        }

        public override int DefiningPointsCount()
        {
            return 2;
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
