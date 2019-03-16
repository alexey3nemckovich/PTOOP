using System;
using System.Drawing;
using System.Collections.Generic;

namespace GraphicsEditor.Shapes
{
    [Serializable]
    class Square : Rectangle
    {
        public Square(string typeName, List<Point> points, Color color) 
            : base(typeName, points, color)
        {
            this.Height = Math.Min(this.Height, this.Width);
            this.Width = this.Height;
        }
    }
}
