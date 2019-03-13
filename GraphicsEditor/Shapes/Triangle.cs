﻿using System.Collections.Generic;
using System.Drawing;

namespace GraphicsEditor.Shapes
{
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
