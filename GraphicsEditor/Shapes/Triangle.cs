using System.Collections.Generic;
using System.Drawing;
using System;

namespace GraphicsEditor.Shapes
{
    [Serializable]
    class Triangle : Shape
    {        
        public Triangle()
        {

        }

        public Triangle(string typeName, List<Point> points, Color color)
            : base(typeName, points, color)
        {

        }
    }
}
