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

        public Shape Create(List<Point> points, Color penColor, Color brushColor)
        {
            return new Circle(ShapeTypeName(), points, penColor, brushColor);
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
