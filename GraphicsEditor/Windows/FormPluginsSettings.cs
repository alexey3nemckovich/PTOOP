using System.Windows.Forms;
using GraphicsEditor.Engine;

namespace GraphicsEditor.Windows
{
    public partial class FormPluginsSettings : Form
    {
        public FormPluginsSettings()
        {
            InitializeComponent();

            ReloadData();
        }

        private void ReloadData()
        {
            ReloadPluginsTabData();
            ReloadApplyingPluginsTabData();
        }

        private void ReloadPluginsTabData()
        {
            dataGridViewPlugins.Rows.Clear();

            foreach(var pluginEntry in Editor.getInstance().Settings.LoadedPlugins)
            {
                dataGridViewPlugins.Rows.Add(pluginEntry.Key, pluginEntry.Value.Description());
            }
        }

        private void ReloadApplyingPluginsTabData()
        {
            comboBoxPlugins.Text = "";
            comboBoxPlugins.Items.Clear();
            dataGridViewApplyingPluginsOrder.Rows.Clear();

            if(0 != Editor.getInstance().Settings.LoadedPlugins.Count)
            {
                foreach (var pluginEntry in Editor.getInstance().Settings.LoadedPlugins)
                {
                    if (!Editor.getInstance().Settings.OrderedAppliedPluginsList.Contains(pluginEntry.Value))
                    {
                        comboBoxPlugins.Items.Add(pluginEntry.Key);
                    }
                }

                if (0 != comboBoxPlugins.Items.Count)
                {
                    comboBoxPlugins.SelectedIndex = 0;
                }

                int i = 1;
                foreach (Plugin plugin in Editor.getInstance().Settings.OrderedAppliedPluginsList)
                {
                    dataGridViewApplyingPluginsOrder.Rows.Add(i.ToString(), plugin.Name());
                    i++;
                }
            }
        }

        private void buttonTunePlugin_Click(object sender, System.EventArgs e)
        {
            if (dataGridViewPlugins.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewPlugins.SelectedRows[0];

                Functionality.TunePlugin((string)row.Cells[0].Value);
            }
        }

        private void buttonDeletePlugin_Click(object sender, System.EventArgs e)
        {
            if(dataGridViewPlugins.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewPlugins.SelectedRows[0];

                if(Functionality.RemovePlugin((string)row.Cells[0].Value))
                {
                    ReloadData();
                }
            }
        }

        private void buttonLoadPlugin_Click(object sender, System.EventArgs e)
        {
            Functionality.LoadPlugin();

            ReloadData();
        }

        private void buttonApplyPlugin_Click(object sender, System.EventArgs e)
        {
            if(0 != comboBoxPlugins.Items.Count)
            {
                if (Functionality.ApplyPlugin(comboBoxPlugins.SelectedItem.ToString()))
                {
                    ReloadApplyingPluginsTabData();
                }
            }
        }

        private void buttonDeleteFromApplyingPlugins_Click(object sender, System.EventArgs e)
        {
            if(0 != dataGridViewApplyingPluginsOrder.SelectedRows.Count)
            {
                if (Functionality.UnapplyPlugin((string)dataGridViewApplyingPluginsOrder.SelectedRows[0].Cells[1].Value))
                {
                    ReloadApplyingPluginsTabData();
                }
            }
        }
    }
}
