using System.Drawing;
using GraphicsEditor.Shapes;
using GraphicsEditor.ShapeCreators;

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

        public string Name()
        {
            return "Standard triangle renderer";
        }

        public string RenderingShapeTypeName()
        {
            return TriangleCreator.getInstance().ShapeTypeName();
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
