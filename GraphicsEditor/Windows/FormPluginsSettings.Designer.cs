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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPlugins = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLoadPlugin = new System.Windows.Forms.Button();
            this.dataGridViewApplyingPluginsOrder = new System.Windows.Forms.DataGridView();
            this.applying_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplyingPluginsOrder)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPlugins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPlugins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlugins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnDescription});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPlugins.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPlugins.Location = new System.Drawing.Point(8, 7);
            this.dataGridViewPlugins.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPlugins.MultiSelect = false;
            this.dataGridViewPlugins.Name = "dataGridViewPlugins";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPlugins.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPlugins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // dataGridViewApplyingPluginsOrder
            // 
            this.dataGridViewApplyingPluginsOrder.AllowUserToAddRows = false;
            this.dataGridViewApplyingPluginsOrder.AllowUserToDeleteRows = false;
            this.dataGridViewApplyingPluginsOrder.AllowUserToResizeColumns = false;
            this.dataGridViewApplyingPluginsOrder.AllowUserToResizeRows = false;
            this.dataGridViewApplyingPluginsOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewApplyingPluginsOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewApplyingPluginsOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplyingPluginsOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.applying_order,
            this.ColumnPluginName});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewApplyingPluginsOrder.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewApplyingPluginsOrder.Location = new System.Drawing.Point(8, 7);
            this.dataGridViewApplyingPluginsOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewApplyingPluginsOrder.MultiSelect = false;
            this.dataGridViewApplyingPluginsOrder.Name = "dataGridViewApplyingPluginsOrder";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewApplyingPluginsOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewApplyingPluginsOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewApplyingPluginsOrder.Size = new System.Drawing.Size(631, 238);
            this.dataGridViewApplyingPluginsOrder.TabIndex = 4;
            // 
            // applying_order
            // 
            this.applying_order.HeaderText = "Applying order";
            this.applying_order.Name = "applying_order";
            this.applying_order.ReadOnly = true;
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
            this.tabPageAppliedPluginsOrder.Controls.Add(this.dataGridViewApplyingPluginsOrder);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormPluginsSettings";
            this.Text = "FormPluginsSettings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlugins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplyingPluginsOrder)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewApplyingPluginsOrder;
        private System.Windows.Forms.ComboBox comboBoxPlugins;
        private System.Windows.Forms.Button buttonApplyPlugin;
        private System.Windows.Forms.TabControl tabControlPluginsSettings;
        private System.Windows.Forms.TabPage tabPageLoadedPlugins;
        private System.Windows.Forms.TabPage tabPageAppliedPluginsOrder;
        private System.Windows.Forms.Button buttonDeleteFromApplyingPlugins;
        private System.Windows.Forms.Button buttonDeletePlugin;
        private System.Windows.Forms.Button buttonTunePlugin;
        private System.Windows.Forms.DataGridViewTextBoxColumn applying_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPluginName;
    }
}