using GraphicsEditor.Engine;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using GraphicsEditor.Serialization;
using GraphicsEditor.Windows;
using System.Xml.Serialization;
using System.Drawing;

namespace GraphicsEditor
{
    class Common
    {

        public static void LoadPlugin()
        {
            string dllPath = "";
            if (Windows.Utils.SelectDllFile(ref dllPath))
            {
                string loadedPluginName = "";
                if (Editor.getInstance().LoadPlugin(dllPath, ref loadedPluginName))
                {
                    MessageBox.Show(
                        "Successfully loaded new plugin '" + loadedPluginName + "'",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show(
                        "Failed to load plugin from file '" + dllPath + "'",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        public static void TunePlugin(string pluginName)
        {
            if (Editor.getInstance().Settings.LoadedPlugins.ContainsKey(pluginName))
            {
                Plugin plugin = Editor.getInstance().Settings.LoadedPlugins[pluginName];

                if (0 == plugin.ParametersInfo.Count)
                {
                    MessageBox.Show(
                        "Plugin '" + plugin.Name() + "' doesn't have any parameters for tune.",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                }
                else
                {
                    FormTunePlugin formTunePlugin = new FormTunePlugin(plugin);
                    formTunePlugin.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(
                    "Plugin '" + pluginName + "' was not found!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static bool ApplyPlugin(string pluginName)
        {
            if (Editor.getInstance().Settings.LoadedPlugins.ContainsKey(pluginName))
            {
                Editor.getInstance().ApplyPlugin(pluginName);
                return true;
            }
            else
            {
                MessageBox.Show(
                    "Plugin '" + pluginName + "' was not found!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return false;
        }

        public static bool UnapplyPlugin(string pluginName)
        {
            if (Editor.getInstance().Settings.LoadedPlugins.ContainsKey(pluginName))
            {
                Editor.getInstance().UnapplyPlugin(pluginName);
                return true;
            }
            else
            {
                MessageBox.Show(
                    "Plugin '" + pluginName + "' was not found!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return false;
        }

        public static bool RemovePlugin(string pluginName)
        {
            if (Editor.getInstance().Settings.LoadedPlugins.ContainsKey(pluginName))
            {
                Editor.getInstance().RemovePlugin(pluginName);
                return true;
            }

            return false;
        }

        public static bool LoadShapeList()
        {
            string filePath = "";

            string supprotedFormats = "Shape list files (";

            List<string> formatsNames = GetSupportedSerializationFormatsNames();

            for(int i = 0; i < formatsNames.Count; i++)
            {
                supprotedFormats += "*." + formatsNames[i];

                if(formatsNames.Count -1 != i)
                {
                    supprotedFormats += ", ";
                }
            }

            supprotedFormats += ") | ";

            for (int i = 0; i < formatsNames.Count; i++)
            {
                supprotedFormats += "*." + formatsNames[i] + ";";

                if (formatsNames.Count - 1 != i)
                {
                    supprotedFormats += " ";
                }
            }

            if (Windows.Utils.SelectFile(supprotedFormats, ref filePath))
            {
                string errMessage = "";
                if (Editor.getInstance().LoadShapeList(filePath, ref errMessage))
                {
                    MessageBox.Show(
                        "Successfully loaded new shape",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);

                    return true;
                }
                else
                {
                    MessageBox.Show(
                        errMessage,
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            return false;
        }

        public static void SaveShapeList()
        {
            FormSaveShapeList formSaveShapeList = new FormSaveShapeList();
            formSaveShapeList.ShowDialog();
        }

        public static List<string> GetSupportedSerializationFormatsNames()
        {
            List<SerializationFormat> suppotedFormats = SerializationManager.getInstance().GetSupportedFormats();
            List<string> supportedFormatsNames = new List<string>();

            foreach(var format in suppotedFormats)
            {
                supportedFormatsNames.Add(format.ToString());
            }

            return supportedFormatsNames;
        }

        public static bool GetSerializationFormatByName(string formatName, ref SerializationFormat serializationFormat)
        {
            object obj = Enum.Parse(typeof(SerializationFormat), formatName);

            if(null != obj)
            {
                serializationFormat = (SerializationFormat)obj;

                return true;
            }
            else
            {
                return false;
            }
        }

        public static void LoadShapeType()
        {
            string dllPath = "";
            if (Windows.Utils.SelectDllFile(ref dllPath))
            {
                string newShapeTypeName = "";

                if (Editor.getInstance().LoadShapeType(dllPath, ref newShapeTypeName))
                {
                    MessageBox.Show(
                        "Successfully loaded new shape type '" + newShapeTypeName + "'",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show(
                        "Failed to load shape type from file '" + dllPath + "'",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        public static void LoadShapeTypeRenderer()
        {
            string dllPath = "";
            if (Windows.Utils.SelectDllFile(ref dllPath))
            {
                string newRendererName = "";

                if (Editor.getInstance().LoadShapeTypeRenderer(dllPath, ref newRendererName))
                {
                    MessageBox.Show(
                        "Successfully loaded new renderer '" + newRendererName + "'",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show(
                        "Failed to load renderer  from file '" + dllPath + "'",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

    }

    public class XmlColor
    {
        private Color color_ = Color.Black;

        public XmlColor() { }
        public XmlColor(Color c) { color_ = c; }


        public Color ToColor()
        {
            return color_;
        }

        public void FromColor(Color c)
        {
            color_ = c;
        }

        public static implicit operator Color(XmlColor x)
        {
            return x.ToColor();
        }

        public static implicit operator XmlColor(Color c)
        {
            return new XmlColor(c);
        }

        [XmlAttribute]
        public string Web
        {
            get { return ColorTranslator.ToHtml(color_); }
            set
            {
                try
                {
                    if (Alpha == 0xFF) // preserve named color value if possible
                        color_ = ColorTranslator.FromHtml(value);
                    else
                        color_ = Color.FromArgb(Alpha, ColorTranslator.FromHtml(value));
                }
                catch (Exception)
                {
                    color_ = Color.Black;
                }
            }
        }

        [XmlAttribute]
        public byte Alpha
        {
            get { return color_.A; }
            set
            {
                if (value != color_.A) // avoid hammering named color if no alpha change
                    color_ = Color.FromArgb(value, color_);
            }
        }

        public bool ShouldSerializeAlpha() { return Alpha < 0xFF; }
    }

}
