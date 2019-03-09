using System.Drawing;
using System.Collections.Generic;

namespace GraphicsEditor.Shapes
{
    abstract class FilledShape : Shape
    {
        public FilledShape()
        {

        }
        public FilledShape(List<Point> points, Color penColor, Color brushColor):
            base(points, penColor)
        {
            this.Brush = new SolidBrush(brushColor);
        }
        public Brush Brush { get; set; }
    }
}
