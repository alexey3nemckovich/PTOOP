using System.Windows.Forms;
using GraphicsEditor.Engine;
using System.Collections.Generic;

namespace GraphicsEditor.Windows
{
    public partial class FormTunePlugin : Form
    {
        private Plugin plugin;

        public FormTunePlugin(Plugin plugin)
        {
            InitializeComponent();

            this.plugin = plugin;
            LoadParameters();
        }

        private void LoadParameters()
        {
            foreach(var parameterInfoEntry in plugin.ParametersInfo)
            {
                PluginParameterInfo parameterInfo = parameterInfoEntry.Value;

                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell cellParameterName = new DataGridViewTextBoxCell();

                cellParameterName.Value = parameterInfo.Name;

                row.Cells.Add(cellParameterName);

                if(parameterInfo.IsEnum)
                {
                    DataGridViewComboBoxCell comboBoxCellParameterPossibleValues = new DataGridViewComboBoxCell();

                    foreach(string possibleValue in parameterInfo.PossibleValues)
                    {
                        comboBoxCellParameterPossibleValues.Items.Add(possibleValue);
                        
                    }

                    comboBoxCellParameterPossibleValues.Value = parameterInfo.Value.ToString();

                    row.Cells.Add(comboBoxCellParameterPossibleValues);
                }
                else
                {
                    DataGridViewTextBoxCell cellParameterValue = new DataGridViewTextBoxCell();

                    cellParameterValue.Value = parameterInfo.GetValueStringRepresentation();

                    row.Cells.Add(cellParameterValue);
                }

                dataGridViewPluginParameters.Rows.Add(row);
            }
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            Dictionary<string, string> parametersValues = new Dictionary<string, string>();

            foreach(DataGridViewRow row in dataGridViewPluginParameters.Rows)
            {
                parametersValues.Add((string)row.Cells[0].Value, (string)row.Cells[1].Value);
            }

            plugin.Tune(parametersValues);
        }
    }
}
