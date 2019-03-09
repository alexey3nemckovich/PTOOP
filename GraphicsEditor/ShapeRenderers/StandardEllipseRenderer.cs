using GraphicsEditor.Shapes;

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

        public void Render(System.Drawing.Graphics g, Shape shape)
        {
            Ellipse ellipse = (Ellipse)shape;

            g.FillEllipse(
                ellipse.Brush,
                ellipse.Points[0].X,
                ellipse.Points[0].Y,
                ellipse.Length,
                ellipse.Width);
        }
    }
}
