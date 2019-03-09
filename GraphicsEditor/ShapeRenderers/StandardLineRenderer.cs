using System.Drawing;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeRenderers
{
    class StandardLineRenderer : IShapeRenderer
    {
        private static StandardLineRenderer instance;

        private StandardLineRenderer()
        {

        }

        public static StandardLineRenderer getInstance()
        {
            if (instance == null)
                instance = new StandardLineRenderer();
            return instance;
        }

        public void Render(Graphics g, Shape shape)
        {
            Line line = (Line)shape;

            g.DrawLine(
                line.Pen, 
                line.Points[0], 
                line.Points[1]);
        }
    }
}
