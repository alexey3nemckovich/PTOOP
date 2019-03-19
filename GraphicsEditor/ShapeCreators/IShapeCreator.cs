﻿using System.Drawing;
using System.Collections.Generic;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeCreators
{
    public interface IShapeCreator
    {
        Shape Create(Point[] points, Color color);

        int CountDefiningShapePoints();

        string ShapeTypeName();
    }
}
