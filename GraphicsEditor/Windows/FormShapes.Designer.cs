namespace GraphicsEditor
{
    partial class FormShapes
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
            this.dataGridViewShapes = new System.Windows.Forms.DataGridView();
            this.ShapeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShapePoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShapeColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddShape = new System.Windows.Forms.Button();
            this.buttonDeleteShape = new System.Windows.Forms.Button();
            this.buttonSaveShape = new System.Windows.Forms.Button();
            this.buttonLoadShape = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShapes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShapes
            // 
            this.dataGridViewShapes.AllowUserToAddRows = false;
            this.dataGridViewShapes.AllowUserToResizeColumns = false;
            this.dataGridViewShapes.AllowUserToResizeRows = false;
            this.dataGridViewShapes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShapes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShapes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShapeType,
            this.ShapePoints,
            this.ShapeColor});
            this.dataGridViewShapes.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewShapes.Name = "dataGridViewShapes";
            this.dataGridViewShapes.ReadOnly = true;
            this.dataGridViewShapes.RowTemplate.Height = 50;
            this.dataGridViewShapes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewShapes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShapes.Size = new System.Drawing.Size(500, 219);
            this.dataGridViewShapes.TabIndex = 0;
            // 
            // ShapeType
            // 
            this.ShapeType.HeaderText = "Type";
            this.ShapeType.Name = "ShapeType";
            this.ShapeType.ReadOnly = true;
            // 
            // ShapePoints
            // 
            this.ShapePoints.HeaderText = "Defining points";
            this.ShapePoints.Name = "ShapePoints";
            this.ShapePoints.ReadOnly = true;
            // 
            // ShapeColor
            // 
            this.ShapeColor.HeaderText = "Color";
            this.ShapeColor.Name = "ShapeColor";
            this.ShapeColor.ReadOnly = true;
            // 
            // buttonAddShape
            // 
            this.buttonAddShape.Location = new System.Drawing.Point(12, 237);
            this.buttonAddShape.Name = "buttonAddShape";
            this.buttonAddShape.Size = new System.Drawing.Size(100, 34);
            this.buttonAddShape.TabIndex = 1;
            this.buttonAddShape.Text = "Add shape";
            this.buttonAddShape.UseVisualStyleBackColor = true;
            this.buttonAddShape.Click += new System.EventHandler(this.buttonAddShape_Click);
            // 
            // buttonDeleteShape
            // 
            this.buttonDeleteShape.Location = new System.Drawing.Point(142, 237);
            this.buttonDeleteShape.Name = "buttonDeleteShape";
            this.buttonDeleteShape.Size = new System.Drawing.Size(100, 34);
            this.buttonDeleteShape.TabIndex = 2;
            this.buttonDeleteShape.Text = "Delete shape";
            this.buttonDeleteShape.UseVisualStyleBackColor = true;
            this.buttonDeleteShape.Click += new System.EventHandler(this.buttonDeleteShape_Click);
            // 
            // buttonSaveShape
            // 
            this.buttonSaveShape.Location = new System.Drawing.Point(278, 237);
            this.buttonSaveShape.Name = "buttonSaveShape";
            this.buttonSaveShape.Size = new System.Drawing.Size(100, 34);
            this.buttonSaveShape.TabIndex = 3;
            this.buttonSaveShape.Text = "Save shape";
            this.buttonSaveShape.UseVisualStyleBackColor = true;
            this.buttonSaveShape.Click += new System.EventHandler(this.buttonSaveShape_Click);
            // 
            // buttonLoadShape
            // 
            this.buttonLoadShape.Location = new System.Drawing.Point(412, 237);
            this.buttonLoadShape.Name = "buttonLoadShape";
            this.buttonLoadShape.Size = new System.Drawing.Size(100, 34);
            this.buttonLoadShape.TabIndex = 4;
            this.buttonLoadShape.Text = "Load shape";
            this.buttonLoadShape.UseVisualStyleBackColor = true;
            this.buttonLoadShape.Click += new System.EventHandler(this.buttonLoadShape_Click);
            // 
            // FormShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 283);
            this.Controls.Add(this.buttonLoadShape);
            this.Controls.Add(this.buttonSaveShape);
            this.Controls.Add(this.buttonDeleteShape);
            this.Controls.Add(this.buttonAddShape);
            this.Controls.Add(this.dataGridViewShapes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormShapes";
            this.Text = "Shapes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShapes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShapes;
        private System.Windows.Forms.Button buttonAddShape;
        private System.Windows.Forms.Button buttonDeleteShape;
        private System.Windows.Forms.Button buttonSaveShape;
        private System.Windows.Forms.Button buttonLoadShape;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShapeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShapePoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShapeColor;
    }
}