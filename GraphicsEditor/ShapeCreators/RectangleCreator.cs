using System;
using System.Drawing;
using System.Collections.Generic;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeCreators
{
    class RectangleCreator : IShapeCreator
    {
        private static RectangleCreator instance;

        private RectangleCreator()
        {

        }

        public static RectangleCreator getInstance()
        {
            if (instance == null)
                instance = new RectangleCreator();
            return instance;
        }

        public Shape Create(Point[] points, Color color)
        {
            return new Shapes.Rectangle(ShapeTypeName(), points, color);
        }

        public int CountDefiningShapePoints()
        {
            return 2;
        }

        public string ShapeTypeName()
        {
            return "Rectangle";
        }
    }
}
