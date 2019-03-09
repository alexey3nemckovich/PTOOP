using System.Drawing;
using System.Collections.Generic;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeCreators
{
    class TriangleCreator
    {
        public Shape Create(List<Point> points, Color penColor, Color brushColor)
        {
            return new Triangle(points, penColor, brushColor);
        }
    }
}
