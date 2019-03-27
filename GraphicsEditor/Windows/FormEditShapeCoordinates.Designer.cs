namespace GraphicsEditor.Windows
{
    partial class FormEditShapeCoordinates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditShapeCoordinates));
            this.dataGridViewCoordinates = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoordinates)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCoordinates
            // 
            this.dataGridViewCoordinates.AllowUserToAddRows = false;
            this.dataGridViewCoordinates.AllowUserToDeleteRows = false;
            this.dataGridViewCoordinates.AllowUserToResizeColumns = false;
            this.dataGridViewCoordinates.AllowUserToResizeRows = false;
            this.dataGridViewCoordinates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoordinates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnY});
            this.dataGridViewCoordinates.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridViewCoordinates.Location = new System.Drawing.Point(16, 15);
            this.dataGridViewCoordinates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCoordinates.MultiSelect = false;
            this.dataGridViewCoordinates.Name = "dataGridViewCoordinates";
            this.dataGridViewCoordinates.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCoordinates.Size = new System.Drawing.Size(323, 185);
            this.dataGridViewCoordinates.TabIndex = 0;
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Name = "ColumnX";
            // 
            // ColumnY
            // 
            this.ColumnY.HeaderText = "Y";
            this.ColumnY.Name = "ColumnY";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(107, 207);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(141, 43);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormEditShapeCoordinates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 265);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewCoordinates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormEditShapeCoordinates";
            this.Text = "Edit shape coordinates";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoordinates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCoordinates;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY;
    }
}