using System.Drawing;
using System.Collections.Generic;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeCreators
{
    class TriangleCreator : IShapeCreator
    {
        private static TriangleCreator instance;

        private TriangleCreator()
        {

        }

        public static TriangleCreator getInstance()
        {
            if (instance == null)
                instance = new TriangleCreator();
            return instance;
        }

        public Shape Create(Point[] points, Color color)
        {
            return new Triangle(ShapeTypeName(), points, color);
        }

        public int CountDefiningShapePoints()
        {
            return 3;
        }

        public string ShapeTypeName()
        {
            return "Triangle";
        }
    }
}
