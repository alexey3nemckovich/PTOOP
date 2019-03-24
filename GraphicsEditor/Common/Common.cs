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

        public static void LoadShapeList()
        {
            string shapePath = "";

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

            if (Utils.selectFile(supprotedFormats, ref shapePath))
            {
                if (Editor.getInstance().LoadShapeList(shapePath))
                {
                    MessageBox.Show(
                        "Successfully loaded new shape",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show(
                        "Failed to load shape",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
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
            if (Utils.selectFile("Dll files (*.dll)|*.dll", ref dllPath))
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
            if (Utils.selectFile("Dll files (*.dll)|*.dll", ref dllPath))
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
