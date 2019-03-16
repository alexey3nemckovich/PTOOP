using System.Drawing;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeRenderers
{
    public interface IShapeRenderer
    {
        string Name();

        string RenderingShapeTypeName();

        void Render(Graphics g, Shape shape);
    }
}
