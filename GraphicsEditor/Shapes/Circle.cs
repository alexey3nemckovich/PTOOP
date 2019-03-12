﻿using System;
using System.Drawing;
using System.Collections.Generic;

namespace GraphicsEditor.Shapes
{
    class Circle : Ellipse
    {
        public Circle(string typeName, List<Point> points, Color penColor, Color brushColor)
            : base(typeName, points, penColor, brushColor)
        {
            this.Width = Math.Min(this.Height, this.Width);
            this.Height = this.Width;
        }
    }
}
