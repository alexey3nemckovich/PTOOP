using GraphicsEditor.Shapes;
using GraphicsEditor.ShapeRenderers;
using System.Drawing;
using PolygonShapeType;

namespace StandardPolygonRenderer
{
    public class StandardPolygonRenderer : IShapeRenderer
    {
        private static StandardPolygonRenderer instance;

        public StandardPolygonRenderer()
        {

        }

        public static StandardPolygonRenderer getInstance()
        {
            if (instance == null)
                instance = new StandardPolygonRenderer();
            return instance;
        }

        public string Name()
        {
            return "Standard polygon renderer";
        }

        public string RenderingShapeTypeName()
        {
            return PolygonCreator.getInstance().ShapeTypeName();
        }

        public void Render(Graphics g, Shape shape)
        {
            Polygon polygon = (Polygon)shape;

            g.FillPolygon(
                new SolidBrush(polygon.Color),
                polygon.Points.ToArray());
        }
    }
}
