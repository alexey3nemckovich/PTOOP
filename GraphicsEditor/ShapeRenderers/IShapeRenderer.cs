using System.Drawing;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeRenderers
{
    interface IShapeRenderer
    {
        string Name();

        void Render(Graphics g, Shape shape);
    }
}
