using GraphicsEditor.Shapes;
using System.Collections.Generic;
using System;

namespace GraphicsEditor.Engine
{
    [Serializable]
    public class ListOfShapes
    {
        public Shape[] Shapes { get; set; }

        public ListOfShapes()
        {
            Clear();
        }

        public void Clear()
        {
            Shapes = new Shape[0];
        }

        public void AddShape(Shape shape)
        {
            List<Shape> shapesList = new List<Shape>(Shapes);

            shapesList.Add(shape);

            Shapes = shapesList.ToArray();
        }

        public void RemoveShape(Shape shape)
        {
            List<Shape> shapesList = new List<Shape>(Shapes);

            shapesList.Remove(shape);

            Shapes = shapesList.ToArray();
        }

        [Serializable]
        protected struct SerializeInfo
        {
            public int combatUnitListCount;
            public SerializeInfo(int combatUnitListCount)
            {
                this.combatUnitListCount = combatUnitListCount;
            }
        }
    }
}
