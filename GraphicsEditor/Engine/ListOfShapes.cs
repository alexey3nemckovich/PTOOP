using GraphicsEditor.Shapes;
using System.Collections.Generic;

namespace GraphicsEditor.Engine
{
    class ListOfShapes
    {
        public List<Shape> Shapes { get; }

        public ListOfShapes()
        {
            Shapes = new List<Shape>();
        }

        public void Clear()
        {
            Shapes.Clear();
        }

        public void AddShape(Shape shape)
        {
            Shapes.Add(shape);
        }

        public void RemoveShape(Shape shape)
        {
            Shapes.Remove(shape);
        }
    }
}
