using System.Collections.Generic;
using System.Drawing;


namespace GraphicsEditor.Shapes
{
    abstract class Shape
    {
        public Shape()
        {

        }

        public Shape(List<Point> points, Color penColor)
        {
            this.Points = points;
            this.Pen = new Pen(penColor);
        }

        public abstract int DefiningPointsCount();

        public List<Point> Points { get; set; }

        public Pen Pen { get; set; }
    }
}
