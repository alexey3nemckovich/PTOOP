using System.Drawing;
using System.Collections.Generic;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeCreators
{
    class CircleCreator : IShapeCreator
    {
        public Shape Create(List<Point> points, Color penColor, Color brushColor)
        {
            return new Circle(points, penColor, brushColor);
        }
    }
}
