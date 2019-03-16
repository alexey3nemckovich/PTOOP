using System.Drawing;
using System.Collections.Generic;

namespace GraphicsEditor.Shapes
{
    public abstract class Shape
    {
        public Shape()
        {

        }

        public Shape(string typeName, List<Point> points, Color color)
        {
            this.TypeName = typeName;
            this.Points = points;
            this.Color = color;
            //this.Pen = new Pen(penColor);
            //this.Brush = new SolidBrush(brushColor);
        }

        public string TypeName { get; }

        public List<Point> Points { get; set; }

        public Color Color { get; set; }
    }
}
