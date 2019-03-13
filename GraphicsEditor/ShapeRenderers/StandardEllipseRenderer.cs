using GraphicsEditor.Shapes;
using System.Drawing;

namespace GraphicsEditor.ShapeRenderers
{
    class StandardEllipseRenderer : IShapeRenderer
    {
        private static StandardEllipseRenderer instance;

        private StandardEllipseRenderer()
        {

        }

        public static StandardEllipseRenderer getInstance()
        {
            if (instance == null)
                instance = new StandardEllipseRenderer();
            return instance;
        }

        public string Name()
        {
            return "Standard ellipse renderer";
        }

        public void Render(System.Drawing.Graphics g, Shape shape)
        {
            Ellipse ellipse = (Ellipse)shape;

            g.FillEllipse(
                new SolidBrush(ellipse.Color),
                ellipse.Points[0].X,
                ellipse.Points[0].Y,
                ellipse.Width,
                ellipse.Height);
        }
    }
}
