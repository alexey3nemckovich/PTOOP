using System.Drawing;
using System.Collections.Generic;

namespace GraphicsEditor.Shapes
{
    class Line : Shape
    {
        public Line()
        {

        }

        public Line(Point point1, Point point2, Color penColor):
            base(new List<Point>() { point1, point2 }, penColor)
        {

        }

        public override int DefiningPointsCount()
        {
            return 2;
        }
    }
}
