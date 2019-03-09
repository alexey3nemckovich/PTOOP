using System;
using System.Drawing;
using System.Collections.Generic;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeCreators
{
    class RectangleCreator
    {
        public Shape Create(List<Point> points, Color penColor, Color brushColor)
        {
            return new Shapes.Rectangle(points, penColor, brushColor);
        }
    }
}
