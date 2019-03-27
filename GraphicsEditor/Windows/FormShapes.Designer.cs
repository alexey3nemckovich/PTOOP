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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShapes));
            this.dataGridViewShapes = new System.Windows.Forms.DataGridView();
            this.ShapeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShapePoints = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ShapeColor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonAddShape = new System.Windows.Forms.Button();
            this.buttonDeleteShape = new System.Windows.Forms.Button();
            this.buttonSaveShapeList = new System.Windows.Forms.Button();
            this.buttonLoadShapeList = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
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
            this.dataGridViewShapes.Location = new System.Drawing.Point(16, 15);
            this.dataGridViewShapes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewShapes.MultiSelect = false;
            this.dataGridViewShapes.Name = "dataGridViewShapes";
            this.dataGridViewShapes.ReadOnly = true;
            this.dataGridViewShapes.RowTemplate.Height = 50;
            this.dataGridViewShapes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewShapes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShapes.Size = new System.Drawing.Size(667, 270);
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
            this.ShapePoints.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ShapePoints.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ShapeColor
            // 
            this.ShapeColor.HeaderText = "Color";
            this.ShapeColor.Name = "ShapeColor";
            this.ShapeColor.ReadOnly = true;
            this.ShapeColor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ShapeColor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // buttonAddShape
            // 
            this.buttonAddShape.Location = new System.Drawing.Point(16, 292);
            this.buttonAddShape.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddShape.Name = "buttonAddShape";
            this.buttonAddShape.Size = new System.Drawing.Size(133, 42);
            this.buttonAddShape.TabIndex = 1;
            this.buttonAddShape.Text = "Add shape";
            this.buttonAddShape.UseVisualStyleBackColor = true;
            this.buttonAddShape.Click += new System.EventHandler(this.buttonAddShape_Click);
            // 
            // buttonDeleteShape
            // 
            this.buttonDeleteShape.Location = new System.Drawing.Point(189, 292);
            this.buttonDeleteShape.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteShape.Name = "buttonDeleteShape";
            this.buttonDeleteShape.Size = new System.Drawing.Size(133, 42);
            this.buttonDeleteShape.TabIndex = 2;
            this.buttonDeleteShape.Text = "Delete shape";
            this.buttonDeleteShape.UseVisualStyleBackColor = true;
            this.buttonDeleteShape.Click += new System.EventHandler(this.buttonDeleteShape_Click);
            // 
            // buttonSaveShapeList
            // 
            this.buttonSaveShapeList.Location = new System.Drawing.Point(371, 292);
            this.buttonSaveShapeList.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveShapeList.Name = "buttonSaveShapeList";
            this.buttonSaveShapeList.Size = new System.Drawing.Size(133, 42);
            this.buttonSaveShapeList.TabIndex = 3;
            this.buttonSaveShapeList.Text = "Save list";
            this.buttonSaveShapeList.UseVisualStyleBackColor = true;
            this.buttonSaveShapeList.Click += new System.EventHandler(this.buttonSaveShapeList_Click);
            // 
            // buttonLoadShapeList
            // 
            this.buttonLoadShapeList.Location = new System.Drawing.Point(549, 292);
            this.buttonLoadShapeList.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadShapeList.Name = "buttonLoadShapeList";
            this.buttonLoadShapeList.Size = new System.Drawing.Size(133, 42);
            this.buttonLoadShapeList.TabIndex = 4;
            this.buttonLoadShapeList.Text = "Load list";
            this.buttonLoadShapeList.UseVisualStyleBackColor = true;
            this.buttonLoadShapeList.Click += new System.EventHandler(this.buttonLoadShapeList_Click);
            // 
            // FormShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 348);
            this.Controls.Add(this.buttonLoadShapeList);
            this.Controls.Add(this.buttonSaveShapeList);
            this.Controls.Add(this.buttonDeleteShape);
            this.Controls.Add(this.buttonAddShape);
            this.Controls.Add(this.dataGridViewShapes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button buttonSaveShapeList;
        private System.Windows.Forms.Button buttonLoadShapeList;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShapeType;
        private System.Windows.Forms.DataGridViewButtonColumn ShapePoints;
        private System.Windows.Forms.DataGridViewButtonColumn ShapeColor;
    }
}