using System;
using System.Windows.Forms;
using GraphicsEditor.Engine;
using GraphicsEditor.Serialization;

namespace GraphicsEditor.Windows
{
    public partial class FormSaveShapeList : Form
    {
        public FormSaveShapeList()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            comboBoxSerializationFormats.Items.AddRange(Functionality.GetSupportedSerializationFormatsNames().ToArray());
            comboBoxSerializationFormats.SelectedIndex = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string dirPath = "";
            if (Utils.SelectFolder(ref dirPath))
            {
                string selectedFormatName = comboBoxSerializationFormats.SelectedItem.ToString();
                SerializationFormat serializationFormat = SerializationFormat.Binary;

                if(Functionality.GetSerializationFormatByName(selectedFormatName, ref serializationFormat))
                {
                    string filePath = "";
                    if (Editor.getInstance().SaveShapeList(serializationFormat, dirPath, ref filePath))
                    {
                        MessageBox.Show(
                            "Shape successfully stored to '" + filePath + "'",
                            "",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show(
                            "Failed to load save shape",
                            "",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                            "Unsuppoted serialization format",
                            "",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
        }
    }
}
