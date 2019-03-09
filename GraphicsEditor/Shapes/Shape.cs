using System.Drawing;
using System.Collections.Generic;

namespace GraphicsEditor.Shapes
{
    abstract class Shape
    {
        public Shape()
        {

        }

        public Shape(List<Point> points, Color penColor, Color brushColor)
        {
            this.Points = points;
            this.Pen = new Pen(penColor);
            this.Brush = new SolidBrush(brushColor);
        }

        public abstract int DefiningPointsCount();

        public List<Point> Points { get; set; }

        public Pen Pen { get; set; }

        public Brush Brush { get; set; }
    }
}
