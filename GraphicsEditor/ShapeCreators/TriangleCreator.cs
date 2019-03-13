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

        public Shape Create(List<Point> points, Color penColor, Color brushColor)
        {
            return new Triangle(ShapeTypeName(), points, penColor, brushColor);
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
