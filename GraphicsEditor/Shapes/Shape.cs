using System.Drawing;
using System.Collections.Generic;

namespace GraphicsEditor.Shapes
{
    abstract class Shape
    {
        public Shape()
        {

        }

        public Shape(string typeName, List<Point> points, Color penColor, Color brushColor)
        {
            this.TypeName = typeName;
            this.Points = points;
            this.Pen = new Pen(penColor);
            this.Brush = new SolidBrush(brushColor);
        }

        public string TypeName { get; }

        public List<Point> Points { get; set; }

        public Pen Pen { get; set; }

        public Brush Brush { get; set; }
    }
}
