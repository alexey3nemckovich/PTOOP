using System;
using System.Drawing;
using System.Collections.Generic;

namespace GraphicsEditor.Shapes
{
    [Serializable]
    class Line : Shape
    {
        public Line()
        {

        }

        public Line(string typeName, List<Point> points, Color color):
            base(typeName, points, color)
        {

        }
    }
}
