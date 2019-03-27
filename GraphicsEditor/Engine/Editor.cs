using System.Drawing;
using System.Collections.Generic;
using System.Reflection;
using GraphicsEditor.ShapeCreators;
using GraphicsEditor.ShapeRenderers;
using GraphicsEditor.Common;
using GraphicsEditor.Shapes;
using System.IO;
using GraphicsEditor.Serialization;
using System;

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

        public bool LoadPlugin(string filePath, ref string loadedPluginName)
        {
            Plugin newPlugin = GetInstanceOfTypeFromAssembly<Plugin>(filePath);

            if (null != newPlugin)
            {
                Settings.RegisterPlugin(newPlugin);
                loadedPluginName = newPlugin.Name();

                return true;
            }
            else
            {
                return false;
            }
        }

        public void ApplyPlugin(string pluginName)
        {
            Plugin plugin = Settings.LoadedPlugins[pluginName];
            Settings.ApplyPlugin(plugin);
        }

        public void UnapplyPlugin(string pluginName)
        {
            Plugin plugin = Settings.LoadedPlugins[pluginName];
            Settings.UnapplyPlugin(plugin);
        }

        public bool LoadShapeList(string filePath, ref string errorMessage)
        {
            try
            {
                string formatName = Path.GetExtension(filePath);
                if (formatName.Length > 1)
                {
                    formatName = formatName.Substring(1);
                }

                SerializationFormat serializationFormat = SerializationFormat.Binary;
                if (Functionality.GetSerializationFormatByName(formatName, ref serializationFormat))
                {
                    ISerializator serializator = SerializationManager.getInstance().GetSerializatorForFormat(serializationFormat);

                    if (null != serializator)
                    {
                        using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                        {
                            //plugins work routine
                            var bytes = Utils.ReadStream(fileStream);
                            for(int i = Settings.OrderedAppliedPluginsList.Count - 1; i >= 0; i--)
                            {
                                bytes = Settings.OrderedAppliedPluginsList[i].ProcessDataOnLoad(filePath, serializationFormat, bytes);
                            }

                            //shapes deserealization
                            using (MemoryStream memoryStream = new MemoryStream(bytes))
                            {
                                ListOfShapes loadedShapeList = serializator.Deserialize<ListOfShapes>(memoryStream);

                                if (null != loadedShapeList)
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
                }

                return false;
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                return false;
            }
        }

        public bool SaveShapeList(SerializationFormat serializationFormat, string dirPath, ref string filePath)
        {
            string extension = serializationFormat.ToString();
            var shapeFilesOfSelectedFormat = new HashSet<string>(Directory.GetFiles(dirPath, "*." + extension));

            int i = 0;
            do
            {
                filePath = dirPath + "\\" + "shape_" + i + "." + serializationFormat.ToString();
                i++;
            } while (shapeFilesOfSelectedFormat.Contains(filePath));

            ISerializator serializator = SerializationManager.getInstance().GetSerializatorForFormat(serializationFormat);
            if (null != serializator)
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    serializator.Serialize(memoryStream, ListOfShapes);

                    //plugins work routine
                    var dataToSave = Utils.ReadStream(memoryStream);
                    foreach (Plugin plugin in Settings.OrderedAppliedPluginsList)
                    {
                        dataToSave = plugin.ProcessDataOnSave(filePath, serializationFormat, dataToSave);
                    }

                    //save data to file
                    using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
                    {
                        fileStream.Write(dataToSave, 0, dataToSave.Length);
                    }
                }

                return true;
            }

            return false;
        }

        public void RemovePlugin(string pluginName)
        {
            Plugin plugin = Settings.LoadedPlugins[pluginName];
            Settings.RemovePlugin(plugin);
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
            try
            {
                Assembly asm = Assembly.LoadFrom(filePath);

                foreach (var type in asm.GetTypes())
                {
                    if (null != type.GetInterface(typeof(T).FullName))
                    {
                        return (T)asm.CreateInstance(type.FullName);
                    }

                    System.Type baseType = type.BaseType;
                    while (typeof(object) != baseType)
                    {
                        if (baseType.FullName == typeof(T).FullName)
                        {
                            return (T)asm.CreateInstance(type.FullName);
                        }
                        else
                        {
                            baseType = baseType.BaseType;
                        }
                    }
                }
            }
            catch(Exception)
            {

            }

            return default(T);
        }
    }
}
