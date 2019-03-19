using System;
using System.Drawing;
using System.Collections.Generic;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeCreators
{
    class SquareCreator : IShapeCreator
    {
        private static SquareCreator instance;

        private SquareCreator()
        {

        }

        public static SquareCreator getInstance()
        {
            if (instance == null)
                instance = new SquareCreator();
            return instance;
        }

        public Shape Create(Point[] points, Color color)
        {
            return new Square(ShapeTypeName(), points, color);
        }

        public int CountDefiningShapePoints()
        {
            return 2;
        }

        public string ShapeTypeName()
        {
            return "Square";
        }
    }
}
