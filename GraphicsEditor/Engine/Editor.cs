using System.Drawing;
using System.Collections.Generic;

namespace GraphicsEditor.Engine
{
    class Editor
    {
        private static Editor instance;

        private Editor()
        {
            Init();

            Reset();
        }

        private void Init()
        {
            Settings = new Settings();
            ListOfShapes = new ListOfShapes();
        }

        public static Editor getInstance()
        {
            if (instance == null)
                instance = new Editor();
            return instance;
        }

        public Settings Settings { get; private set; }
        public ListOfShapes ListOfShapes { get; private set; }

        public void Reset()
        {
            Settings.Reset();
            ListOfShapes.Clear();
        }

        public bool CreateShape(string shapeType, List<Point> definingPoints)
        {
            ShapeCreators.IShapeCreator shapeTypeCreator = Settings.GetCreatorForShapeType(shapeType);
            if(null != shapeTypeCreator)
            {
                ListOfShapes.AddShape(
                    shapeTypeCreator.Create(definingPoints, Color.Black, Color.Black));

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
