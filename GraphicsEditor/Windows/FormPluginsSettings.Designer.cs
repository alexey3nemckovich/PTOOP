namespace GraphicsEditor.Windows
{
    partial class FormPluginsSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewPlugins = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLoadPlugin = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPluginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxPlugins = new System.Windows.Forms.ComboBox();
            this.buttonApplyPlugin = new System.Windows.Forms.Button();
            this.tabControlPluginsSettings = new System.Windows.Forms.TabControl();
            this.tabPageLoadedPlugins = new System.Windows.Forms.TabPage();
            this.buttonDeletePlugin = new System.Windows.Forms.Button();
            this.buttonTunePlugin = new System.Windows.Forms.Button();
            this.tabPageAppliedPluginsOrder = new System.Windows.Forms.TabPage();
            this.buttonDeleteFromApplyingPlugins = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlugins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControlPluginsSettings.SuspendLayout();
            this.tabPageLoadedPlugins.SuspendLayout();
            this.tabPageAppliedPluginsOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPlugins
            // 
            this.dataGridViewPlugins.AllowUserToAddRows = false;
            this.dataGridViewPlugins.AllowUserToDeleteRows = false;
            this.dataGridViewPlugins.AllowUserToResizeColumns = false;
            this.dataGridViewPlugins.AllowUserToResizeRows = false;
            this.dataGridViewPlugins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPlugins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlugins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnDescription});
            this.dataGridViewPlugins.Location = new System.Drawing.Point(8, 7);
            this.dataGridViewPlugins.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPlugins.MultiSelect = false;
            this.dataGridViewPlugins.Name = "dataGridViewPlugins";
            this.dataGridViewPlugins.Size = new System.Drawing.Size(631, 238);
            this.dataGridViewPlugins.TabIndex = 0;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.HeaderText = "Description";
            this.ColumnDescription.Name = "ColumnDescription";
            // 
            // buttonLoadPlugin
            // 
            this.buttonLoadPlugin.Location = new System.Drawing.Point(456, 252);
            this.buttonLoadPlugin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadPlugin.Name = "buttonLoadPlugin";
            this.buttonLoadPlugin.Size = new System.Drawing.Size(185, 49);
            this.buttonLoadPlugin.TabIndex = 1;
            this.buttonLoadPlugin.Text = "Load plugin";
            this.buttonLoadPlugin.UseVisualStyleBackColor = true;
            this.buttonLoadPlugin.Click += new System.EventHandler(this.buttonLoadPlugin_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOrderNumber,
            this.ColumnPluginName});
            this.dataGridView1.Location = new System.Drawing.Point(8, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 238);
            this.dataGridView1.TabIndex = 4;
            // 
            // ColumnOrderNumber
            // 
            this.ColumnOrderNumber.HeaderText = "Number";
            this.ColumnOrderNumber.Name = "ColumnOrderNumber";
            this.ColumnOrderNumber.ReadOnly = true;
            // 
            // ColumnPluginName
            // 
            this.ColumnPluginName.HeaderText = "Name";
            this.ColumnPluginName.Name = "ColumnPluginName";
            this.ColumnPluginName.ReadOnly = true;
            // 
            // comboBoxPlugins
            // 
            this.comboBoxPlugins.FormattingEnabled = true;
            this.comboBoxPlugins.Location = new System.Drawing.Point(67, 252);
            this.comboBoxPlugins.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPlugins.Name = "comboBoxPlugins";
            this.comboBoxPlugins.Size = new System.Drawing.Size(236, 24);
            this.comboBoxPlugins.TabIndex = 5;
            // 
            // buttonApplyPlugin
            // 
            this.buttonApplyPlugin.Location = new System.Drawing.Point(67, 286);
            this.buttonApplyPlugin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonApplyPlugin.Name = "buttonApplyPlugin";
            this.buttonApplyPlugin.Size = new System.Drawing.Size(237, 42);
            this.buttonApplyPlugin.TabIndex = 6;
            this.buttonApplyPlugin.Text = "Apply";
            this.buttonApplyPlugin.UseVisualStyleBackColor = true;
            this.buttonApplyPlugin.Click += new System.EventHandler(this.buttonApplyPlugin_Click);
            // 
            // tabControlPluginsSettings
            // 
            this.tabControlPluginsSettings.Controls.Add(this.tabPageLoadedPlugins);
            this.tabControlPluginsSettings.Controls.Add(this.tabPageAppliedPluginsOrder);
            this.tabControlPluginsSettings.Location = new System.Drawing.Point(0, 1);
            this.tabControlPluginsSettings.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlPluginsSettings.Name = "tabControlPluginsSettings";
            this.tabControlPluginsSettings.SelectedIndex = 0;
            this.tabControlPluginsSettings.Size = new System.Drawing.Size(665, 363);
            this.tabControlPluginsSettings.TabIndex = 7;
            // 
            // tabPageLoadedPlugins
            // 
            this.tabPageLoadedPlugins.Controls.Add(this.buttonDeletePlugin);
            this.tabPageLoadedPlugins.Controls.Add(this.buttonTunePlugin);
            this.tabPageLoadedPlugins.Controls.Add(this.dataGridViewPlugins);
            this.tabPageLoadedPlugins.Controls.Add(this.buttonLoadPlugin);
            this.tabPageLoadedPlugins.Location = new System.Drawing.Point(4, 25);
            this.tabPageLoadedPlugins.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageLoadedPlugins.Name = "tabPageLoadedPlugins";
            this.tabPageLoadedPlugins.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageLoadedPlugins.Size = new System.Drawing.Size(657, 334);
            this.tabPageLoadedPlugins.TabIndex = 0;
            this.tabPageLoadedPlugins.Text = "Loaded plugins";
            this.tabPageLoadedPlugins.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePlugin
            // 
            this.buttonDeletePlugin.Location = new System.Drawing.Point(248, 252);
            this.buttonDeletePlugin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeletePlugin.Name = "buttonDeletePlugin";
            this.buttonDeletePlugin.Size = new System.Drawing.Size(160, 49);
            this.buttonDeletePlugin.TabIndex = 3;
            this.buttonDeletePlugin.Text = "Delete plugin";
            this.buttonDeletePlugin.UseVisualStyleBackColor = true;
            this.buttonDeletePlugin.Click += new System.EventHandler(this.buttonDeletePlugin_Click);
            // 
            // buttonTunePlugin
            // 
            this.buttonTunePlugin.Location = new System.Drawing.Point(11, 252);
            this.buttonTunePlugin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTunePlugin.Name = "buttonTunePlugin";
            this.buttonTunePlugin.Size = new System.Drawing.Size(176, 49);
            this.buttonTunePlugin.TabIndex = 2;
            this.buttonTunePlugin.Text = "Tune plugin";
            this.buttonTunePlugin.UseVisualStyleBackColor = true;
            this.buttonTunePlugin.Click += new System.EventHandler(this.buttonTunePlugin_Click);
            // 
            // tabPageAppliedPluginsOrder
            // 
            this.tabPageAppliedPluginsOrder.Controls.Add(this.buttonDeleteFromApplyingPlugins);
            this.tabPageAppliedPluginsOrder.Controls.Add(this.dataGridView1);
            this.tabPageAppliedPluginsOrder.Controls.Add(this.buttonApplyPlugin);
            this.tabPageAppliedPluginsOrder.Controls.Add(this.comboBoxPlugins);
            this.tabPageAppliedPluginsOrder.Location = new System.Drawing.Point(4, 25);
            this.tabPageAppliedPluginsOrder.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAppliedPluginsOrder.Name = "tabPageAppliedPluginsOrder";
            this.tabPageAppliedPluginsOrder.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAppliedPluginsOrder.Size = new System.Drawing.Size(657, 334);
            this.tabPageAppliedPluginsOrder.TabIndex = 1;
            this.tabPageAppliedPluginsOrder.Text = "Applied plugins order";
            this.tabPageAppliedPluginsOrder.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteFromApplyingPlugins
            // 
            this.buttonDeleteFromApplyingPlugins.Location = new System.Drawing.Point(348, 252);
            this.buttonDeleteFromApplyingPlugins.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteFromApplyingPlugins.Name = "buttonDeleteFromApplyingPlugins";
            this.buttonDeleteFromApplyingPlugins.Size = new System.Drawing.Size(228, 75);
            this.buttonDeleteFromApplyingPlugins.TabIndex = 7;
            this.buttonDeleteFromApplyingPlugins.Text = "Delete from appliying plugins";
            this.buttonDeleteFromApplyingPlugins.UseVisualStyleBackColor = true;
            this.buttonDeleteFromApplyingPlugins.Click += new System.EventHandler(this.buttonDeleteFromApplyingPlugins_Click);
            // 
            // FormPluginsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 359);
            this.Controls.Add(this.tabControlPluginsSettings);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormPluginsSettings";
            this.Text = "FormPluginsSettings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlugins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControlPluginsSettings.ResumeLayout(false);
            this.tabPageLoadedPlugins.ResumeLayout(false);
            this.tabPageAppliedPluginsOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlugins;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.Button buttonLoadPlugin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxPlugins;
        private System.Windows.Forms.Button buttonApplyPlugin;
        private System.Windows.Forms.TabControl tabControlPluginsSettings;
        private System.Windows.Forms.TabPage tabPageLoadedPlugins;
        private System.Windows.Forms.TabPage tabPageAppliedPluginsOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPluginName;
        private System.Windows.Forms.Button buttonDeleteFromApplyingPlugins;
        private System.Windows.Forms.Button buttonDeletePlugin;
        private System.Windows.Forms.Button buttonTunePlugin;
    }
}