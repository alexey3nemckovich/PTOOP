using System.Drawing;
using System.Collections.Generic;

namespace GraphicsEditor.Shapes
{
    class Line : Shape
    {
        public Line()
        {

        }

        public Line(List<Point> points, Color penColor):
            base(points, penColor, penColor)
        {

        }
    }
}
