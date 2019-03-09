using System.Drawing;
using System.Collections.Generic;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeCreators
{
    class EllipseCreator
    {
        public Shape Create(List<Point> points, Color penColor, Color brushColor)
        {
            return new Ellipse(points, penColor, brushColor);
        }
    }
}
