using System;
using System.Windows.Forms;
using System.Drawing;
using GraphicsEditor.Engine;

namespace GraphicsEditor.Windows
{
    public partial class FormAddShape : Form
    {
        public string SelectedShapeType { get; private set; }

        public Color SelectedColor;

        public FormAddShape()
        {
            InitializeComponent();

            LoadAvailableShapeTypes();
            setColor(new Color());
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

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog.ShowDialog())
            {
                setColor(colorDialog.Color);
            }
        }

        private void setColor(Color color)
        {
            SelectedColor = colorDialog.Color;
            labelColor.BackColor = color;

            labelColor.Invalidate();
        }

        
    }
}
