using System;
using System.Windows.Forms;
using GraphicsEditor.Engine;

namespace GraphicsEditor.Windows
{
    public partial class FormAddShape : Form
    {
        public string SelectedShapeType { get; private set; }

        public FormAddShape()
        {
            InitializeComponent();

            LoadAvailableShapeTypes();
        }

        private void LoadAvailableShapeTypes()
        {
            comboBoxAvailableShapeTypes.Items.AddRange(
                Editor.getInstance().Settings.GetRenderableShapeTypesNames().ToArray());

            comboBoxAvailableShapeTypes.SelectedIndex = 0;
        }

        private void buttonAddShape_Click(object sender, EventArgs e)
        {
            SelectedShapeType = (string)comboBoxAvailableShapeTypes.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
