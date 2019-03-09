using System;
using System.Drawing;

namespace GraphicsEditor.Shapes
{
    class Circle : Ellipse
    {
        public Circle(Point point1, Point point2, Color brushColor, Color penColor)
            : base(point1, point2, brushColor, penColor)
        {
            this.width = Math.Abs(point1.X - point2.X);
        }

        public override int DefiningPointsCount()
        {
            return 2;
        }
    }
}
