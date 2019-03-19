using System;
using System.Drawing;
using System.Collections.Generic;
using System.Reflection;
using GraphicsEditor.ShapeCreators;
using GraphicsEditor.ShapeRenderers;
using GraphicsEditor.Shapes;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using GraphicsEditor.Serialization;
using System.Text.RegularExpressions;

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

        public bool CreateShape(string shapeType, Point[] definingPoints, Color color)
        {
            ShapeCreators.IShapeCreator shapeTypeCreator = Settings.GetCreatorForShapeType(shapeType);
            if(null != shapeTypeCreator)
            {
                ListOfShapes.AddShape(
                    shapeTypeCreator.Create(definingPoints, color));

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LoadShapeList(string filePath)
        {
            string formatName = Path.GetExtension(filePath);
            if(formatName.Length > 1)
            {
                formatName = formatName.Substring(1);
            }

            SerializationFormat serializationFormat = SerializationFormat.Binary;
            if(Common.GetSerializationFormatByName(formatName, ref serializationFormat))
            {
                ISerializator serializator = SerializationManager.getInstance().GetSerializatorForFormat(serializationFormat);

                if(null != serializator)
                {
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                    {
                        ListOfShapes loadedShapeList = serializator.Deserialize<ListOfShapes>(fileStream);

                        if(null != loadedShapeList)
                        {
                            foreach (Shape shape in loadedShapeList.Shapes)
                            {
                                ListOfShapes.AddShape(shape);
                            }

                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public bool SaveShapeList(SerializationFormat format, string dirPath, ref string filePath)
        {
            string extension = format.ToString();
            var shapeFilesOfSelectedFormat = new HashSet<string>(Directory.GetFiles(dirPath, "*." + extension));

            int i = 0;
            do
            {
                filePath = dirPath + "\\" + "shape_" + i + "." + format.ToString();
                i++;
            } while (shapeFilesOfSelectedFormat.Contains(filePath));

            ISerializator serializator = SerializationManager.getInstance().GetSerializatorForFormat(format);
            if (null != serializator)
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    serializator.Serialize(fileStream, ListOfShapes);
                }

                return true;
            }

            return false;
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
