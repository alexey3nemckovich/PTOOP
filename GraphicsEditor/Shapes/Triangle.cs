using System.Collections.Generic;
using System.Drawing;

namespace GraphicsEditor.Shapes
{
    class Triangle : Shape
    {        
        public Triangle()
        {

        }

        public Triangle(List<Point> points, Color penColor, Color brushColor)
            : base(points, penColor, brushColor)
        {

        }

        public override int DefiningPointsCount()
        {
            return 3;
        }
    }
}
