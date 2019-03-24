using GraphicsEditor.Shapes;
using System.Drawing;
using System;

namespace PolygonShapeType
{
    [Serializable]
    public class Polygon : Shape
    {
        public Polygon()
        {

        }

        public Polygon(string typeName, Point[] points, Color color)
            : base(typeName, points, color)
        {

        }
    }
}
