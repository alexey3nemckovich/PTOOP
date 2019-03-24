using System.Drawing;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeCreators
{
    public interface IShapeCreator
    {
        Shape Create(Point[] points, Color color);

        int CountDefiningShapePoints();

        string ShapeTypeName();
    }
}
