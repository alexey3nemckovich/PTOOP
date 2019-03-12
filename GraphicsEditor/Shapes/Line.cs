using System.Drawing;
using System.Collections.Generic;

namespace GraphicsEditor.Shapes
{
    class Line : Shape
    {
        public Line()
        {

        }

        public Line(string typeName, List<Point> points, Color penColor):
            base(typeName, points, penColor, penColor)
        {

        }
    }
}
