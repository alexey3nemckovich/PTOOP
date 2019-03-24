using GraphicsEditor.ShapeCreators;
using GraphicsEditor.Shapes;
using System.Drawing;

namespace PolygonShapeType
{
    public class PolygonCreator : IShapeCreator
    {
        private static PolygonCreator instance;

        public PolygonCreator()
        {

        }

        public static PolygonCreator getInstance()
        {
            if (instance == null)
                instance = new PolygonCreator();
            return instance;
        }

        public Shape Create(Point[] points, Color color)
        {
            return new Polygon(ShapeTypeName(), points, color);
        }

        public int CountDefiningShapePoints()
        {
            return -1;
        }

        public string ShapeTypeName()
        {
            return "Polygon";
        }
    }
}
