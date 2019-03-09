using System.Collections.Generic;
using System.Drawing;

namespace GraphicsEditor.Shapes
{
    class Triangle : FilledShape
    {        
        public Triangle()
        {

        }

        public Triangle(Point point1, Point point2, Point point3, Color penColor, Color brushColor)
            : base(new List<Point>() { point1, point2, point3 }, penColor, brushColor)
        {

        }

        public override int DefiningPointsCount()
        {
            return 3;
        }
    }
}
