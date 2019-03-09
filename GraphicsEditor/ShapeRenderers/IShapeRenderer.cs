using System.Drawing;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeRenderers
{
    interface IShapeRenderer
    {
        void Render(Graphics g, Shape shape);
    }
}
