using System.Linq;
using System.Windows.Forms;
using GraphicsEditor.Engine;

namespace GraphicsEditor.Windows
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            ReloadSettings();

            dataGridViewShapeTypesRenderers.CellValueChanged += 
                new DataGridViewCellEventHandler(dataGridViewCellValueChanged);
        }

        private void ReloadSettings()
        {
            dataGridViewShapeTypesRenderers.Rows.Clear();

            var shapeTypesInfoMap = Editor.getInstance().Settings.ShapeTypesInfoMap;

            int i = 0;
            foreach(var shapeTypeInfo in shapeTypesInfoMap)
            {
                dataGridViewShapeTypesRenderers.Rows.Add();

                dataGridViewShapeTypesRenderers.Rows[i].Cells[0].Value = shapeTypeInfo.Key;

                DataGridViewComboBoxCell typeRenderesCombobox =
                    dataGridViewShapeTypesRenderers.Rows[i].Cells[1] as DataGridViewComboBoxCell;

                if (shapeTypeInfo.Value.Renderers.Count > 0)
                {
                    typeRenderesCombobox.DataSource = shapeTypeInfo.Value.Renderers.Keys.ToList();
                    typeRenderesCombobox.Value = shapeTypeInfo.Value.Renderer.Name();
                }

                i++;
            }
        }

        private void dataGridViewCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cellShapeType = dataGridViewShapeTypesRenderers.Rows[e.RowIndex].Cells[0];
            DataGridViewComboBoxCell comboBoxCellRenderer = (DataGridViewComboBoxCell)dataGridViewShapeTypesRenderers.Rows[e.RowIndex].Cells[1];

            string shapeTypeName = (string)cellShapeType.Value;
            string rendererName = (string)comboBoxCellRenderer.Value;

            if (null != rendererName)
            {
                var renderer = Editor.getInstance().Settings.GetRendererForShapeType(shapeTypeName, rendererName);
                if (null != renderer)
                {
                    Editor.getInstance().Settings.SetRendererForShapeType(shapeTypeName, renderer);
                }
            }
        }

        private void buttonAddShapeType_Click(object sender, System.EventArgs e)
        {
            if(Functionality.LoadShapeType())
            {
                ReloadSettings();
            }
        }

        private void buttonAddShapeTypeRenderer_Click(object sender, System.EventArgs e)
        {
            if(Functionality.LoadShapeTypeRenderer())
            {
                ReloadSettings();
            }
        }
    }
}
