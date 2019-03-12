using System;
using System.Drawing;
using System.Collections.Generic;

namespace GraphicsEditor.Shapes
{
    class Square : Rectangle
    {
        public Square(string typeName, List<Point> points, Color penColor, Color brushColor) 
            : base(typeName, points, penColor, brushColor)
        {
            this.Height = Math.Min(this.Height, this.Width);
            this.Width = this.Height;
        }
    }
}
