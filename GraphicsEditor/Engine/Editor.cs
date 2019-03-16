using System.Drawing;
using System.Collections.Generic;
using System.Reflection;
using GraphicsEditor.ShapeCreators;
using GraphicsEditor.ShapeRenderers;

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
                    shapeTypeCreator.Create(definingPoints, Color.Black));

                return true;
            }
            else
            {
                return false;
            }
        }

        public void LoadShape(string filePath)
        {

        }

        public bool LoadShapeType(string filePath, ref string shapeTypeLoaded)
        {
            IShapeCreator newShapeTypeCreator = GetInstanceOfTypeFromAssembly<IShapeCreator>(filePath);

            if(null != newShapeTypeCreator)
            {
                Settings.RegisterShapeType(newShapeTypeCreator);

                shapeTypeLoaded = newShapeTypeCreator.ShapeTypeName();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LoadShapeTypeRenderer(string filePath, ref string rendererLoaded)
        {
            IShapeRenderer newShapeRenderer = GetInstanceOfTypeFromAssembly<IShapeRenderer>(filePath);

            if (null != newShapeRenderer)
            {
                Settings.RegisterShapeTypeRenderer(newShapeRenderer);

                rendererLoaded = newShapeRenderer.Name();
                return true;
            }
            else
            {
                return false;
            }
        }

        private T GetInstanceOfTypeFromAssembly<T>(string filePath)
        {
            Assembly asm = Assembly.LoadFrom(filePath);

            foreach (var type in asm.GetTypes())
            {
                if (null != type.GetInterface(typeof(T).FullName))
                {
                    return (T)asm.CreateInstance(type.FullName);
                }
            }

            return default(T);
        }
    }
}
