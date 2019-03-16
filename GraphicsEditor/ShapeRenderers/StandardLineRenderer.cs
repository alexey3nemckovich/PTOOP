using System.Drawing;
using GraphicsEditor.Shapes;
using GraphicsEditor.ShapeCreators;

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

        public string RenderingShapeTypeName()
        {
            return LineCreator.getInstance().ShapeTypeName();
        }

        public string Name()
        {
            return "Standard line renderer";
        }

        public void Render(Graphics g, Shape shape)
        {
            Line line = (Line)shape;

            g.DrawLine(
                new Pen(line.Color), 
                line.Points[0], 
                line.Points[1]);
        }
    }
}
