namespace GraphicsEditor.Windows
{
    partial class FormSettings
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
            this.dataGridViewShapeTypesRenderers = new System.Windows.Forms.DataGridView();
            this.buttonAddShapeType = new System.Windows.Forms.Button();
            this.buttonAddShapeTypeRenderer = new System.Windows.Forms.Button();
            this.ShapeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShapeTypeRenderer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShapeTypesRenderers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShapeTypesRenderers
            // 
            this.dataGridViewShapeTypesRenderers.AllowUserToAddRows = false;
            this.dataGridViewShapeTypesRenderers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShapeTypesRenderers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShapeTypesRenderers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShapeType,
            this.ShapeTypeRenderer});
            this.dataGridViewShapeTypesRenderers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewShapeTypesRenderers.Name = "dataGridViewShapeTypesRenderers";
            this.dataGridViewShapeTypesRenderers.RowTemplate.Height = 50;
            this.dataGridViewShapeTypesRenderers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShapeTypesRenderers.Size = new System.Drawing.Size(496, 207);
            this.dataGridViewShapeTypesRenderers.TabIndex = 0;
            // 
            // buttonAddShapeType
            // 
            this.buttonAddShapeType.Location = new System.Drawing.Point(157, 225);
            this.buttonAddShapeType.Name = "buttonAddShapeType";
            this.buttonAddShapeType.Size = new System.Drawing.Size(200, 37);
            this.buttonAddShapeType.TabIndex = 1;
            this.buttonAddShapeType.Text = "Add shape type";
            this.buttonAddShapeType.UseVisualStyleBackColor = true;
            // 
            // buttonAddShapeTypeRenderer
            // 
            this.buttonAddShapeTypeRenderer.Location = new System.Drawing.Point(157, 268);
            this.buttonAddShapeTypeRenderer.Name = "buttonAddShapeTypeRenderer";
            this.buttonAddShapeTypeRenderer.Size = new System.Drawing.Size(200, 37);
            this.buttonAddShapeTypeRenderer.TabIndex = 2;
            this.buttonAddShapeTypeRenderer.Text = "Add shape type renderer";
            this.buttonAddShapeTypeRenderer.UseVisualStyleBackColor = true;
            // 
            // ShapeType
            // 
            this.ShapeType.HeaderText = "Shape type";
            this.ShapeType.Name = "ShapeType";
            this.ShapeType.ReadOnly = true;
            this.ShapeType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ShapeTypeRenderer
            // 
            this.ShapeTypeRenderer.HeaderText = "Renderer";
            this.ShapeTypeRenderer.Name = "ShapeTypeRenderer";
            this.ShapeTypeRenderer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ShapeTypeRenderer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 313);
            this.Controls.Add(this.buttonAddShapeTypeRenderer);
            this.Controls.Add(this.buttonAddShapeType);
            this.Controls.Add(this.dataGridViewShapeTypesRenderers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSettings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShapeTypesRenderers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShapeTypesRenderers;
        private System.Windows.Forms.Button buttonAddShapeType;
        private System.Windows.Forms.Button buttonAddShapeTypeRenderer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShapeType;
        private System.Windows.Forms.DataGridViewComboBoxColumn ShapeTypeRenderer;
    }
}