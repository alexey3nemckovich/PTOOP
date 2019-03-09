﻿using System.Drawing;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.ShapeRenderers
{
    class StandardRectangleRenderer : IShapeRenderer
    {
        private static StandardRectangleRenderer instance;

        private StandardRectangleRenderer()
        {

        }

        public static StandardRectangleRenderer getInstance()
        {
            if (instance == null)
                instance = new StandardRectangleRenderer();
            return instance;
        }

        public void Render(Graphics g, Shape shape)
        {
            Shapes.Rectangle rectangle = (Shapes.Rectangle)shape;

            g.FillRectangle(
                rectangle.Brush,
                rectangle.Points[0].X,
                rectangle.Points[0].Y,
                rectangle.Length,
                rectangle.Width);
        }
    }
}
