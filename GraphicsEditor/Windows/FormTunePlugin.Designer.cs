namespace GraphicsEditor.Windows
{
    partial class FormTunePlugin
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
            this.dataGridViewPluginParameters = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.ColumnParameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPluginParameters)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPluginParameters
            // 
            this.dataGridViewPluginParameters.AllowUserToAddRows = false;
            this.dataGridViewPluginParameters.AllowUserToDeleteRows = false;
            this.dataGridViewPluginParameters.AllowUserToResizeColumns = false;
            this.dataGridViewPluginParameters.AllowUserToResizeRows = false;
            this.dataGridViewPluginParameters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPluginParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPluginParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnParameter,
            this.ColumnValue});
            this.dataGridViewPluginParameters.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPluginParameters.MultiSelect = false;
            this.dataGridViewPluginParameters.Name = "dataGridViewPluginParameters";
            this.dataGridViewPluginParameters.Size = new System.Drawing.Size(376, 177);
            this.dataGridViewPluginParameters.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(114, 195);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(170, 39);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // ColumnParameter
            // 
            this.ColumnParameter.HeaderText = "Parameter";
            this.ColumnParameter.Name = "ColumnParameter";
            this.ColumnParameter.ReadOnly = true;
            // 
            // ColumnValue
            // 
            this.ColumnValue.HeaderText = "Value";
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormTunePlugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 246);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewPluginParameters);
            this.MaximizeBox = false;
            this.Name = "FormTunePlugin";
            this.Text = "Tune plugin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPluginParameters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPluginParameters;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParameter;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnValue;
    }
}