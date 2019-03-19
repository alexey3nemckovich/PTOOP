using System.Drawing;
using System.Collections.Generic;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeCreators
{
    class CircleCreator : IShapeCreator
    {
        private static CircleCreator instance;

        private CircleCreator()
        {

        }

        public static CircleCreator getInstance()
        {
            if (instance == null)
                instance = new CircleCreator();
            return instance;
        }

        public Shape Create(Point[] points, Color color)
        {
            return new Circle(ShapeTypeName(), points, color);
        }

        public int CountDefiningShapePoints()
        {
            return 2;
        }

        public string ShapeTypeName()
        {
            return "Circle";
        }
    }
}
