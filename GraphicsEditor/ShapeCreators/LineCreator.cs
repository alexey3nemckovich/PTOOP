﻿using System.Drawing;
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

        public Shape Create(Point[] points, Color color)
        {
            return new Line(ShapeTypeName(), points, color);
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
