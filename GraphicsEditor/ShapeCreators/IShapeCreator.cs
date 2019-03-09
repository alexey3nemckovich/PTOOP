using System.Drawing;
using System.Collections.Generic;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeCreators
{
    interface IShapeCreator
    {
        Shape Create(List<Point> points, Color penColor, Color brushColor);

        int CountDefiningShapePoints();

        string ShapeTypeName();
    }
}
