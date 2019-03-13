using System.Drawing;
using System.Collections.Generic;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeCreators
{
    class EllipseCreator : IShapeCreator
    {
        private static EllipseCreator instance;

        private EllipseCreator()
        {

        }

        public static EllipseCreator getInstance()
        {
            if (instance == null)
                instance = new EllipseCreator();
            return instance;
        }

        public Shape Create(List<Point> points, Color color)
        {
            return new Ellipse(ShapeTypeName(), points, color);
        }

        public int CountDefiningShapePoints()
        {
            return 2;
        }

        public string ShapeTypeName()
        {
            return "Ellipse";
        }
    }
}
