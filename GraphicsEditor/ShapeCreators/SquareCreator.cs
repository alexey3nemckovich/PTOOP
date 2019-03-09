using System;
using System.Drawing;
using System.Collections.Generic;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeCreators
{
    class SquareCreator
    {
        public Shape Create(List<Point> points, Color penColor, Color brushColor)
        {
            return new Square(points, penColor, brushColor);
        }
    }
}
