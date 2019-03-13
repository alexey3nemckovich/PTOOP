using System.Drawing;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeRenderers
{
    class StandardTriangleRenderer : IShapeRenderer
    {
        private static StandardTriangleRenderer instance;

        private StandardTriangleRenderer()
        {

        }

        public static StandardTriangleRenderer getInstance()
        {
            if (instance == null)
                instance = new StandardTriangleRenderer();
            return instance;
        }

        public void Render(Graphics g, Shape shape)
        {
            Triangle triangle = (Triangle)shape;

            g.FillPolygon(
                new SolidBrush(triangle.Color),
                triangle.Points.ToArray());
        }
    }
}
