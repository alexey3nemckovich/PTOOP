﻿using System;
using System.Drawing;
using System.Collections.Generic;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeCreators
{
    class LineCreator : IShapeCreator
    {
        private static LineCreator instance;

        private LineCreator()
        {

        }

        public static LineCreator getInstance()
        {
            if (instance == null)
                instance = new LineCreator();
            return instance;
        }

        public Shape Create(List<Point> points, Color penColor, Color brushColor)
        {
            return new Line(points, penColor);
        }

        public int CountDefiningShapePoints()
        {
            return 2;
        }

        public string ShapeTypeName()
        {
            return "Line";
        }
    }
}
