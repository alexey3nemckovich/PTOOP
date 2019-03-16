namespace GraphicsEditor.Windows
{
    partial class FormAddShape
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
            this.comboBoxAvailableShapeTypes = new System.Windows.Forms.ComboBox();
            this.buttonAddShape = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAvailableShapeTypes
            // 
            this.comboBoxAvailableShapeTypes.FormattingEnabled = true;
            this.comboBoxAvailableShapeTypes.Location = new System.Drawing.Point(12, 12);
            this.comboBoxAvailableShapeTypes.Name = "comboBoxAvailableShapeTypes";
            this.comboBoxAvailableShapeTypes.Size = new System.Drawing.Size(182, 21);
            this.comboBoxAvailableShapeTypes.TabIndex = 0;
            // 
            // buttonAddShape
            // 
            this.buttonAddShape.Location = new System.Drawing.Point(53, 73);
            this.buttonAddShape.Name = "buttonAddShape";
            this.buttonAddShape.Size = new System.Drawing.Size(95, 23);
            this.buttonAddShape.TabIndex = 1;
            this.buttonAddShape.Text = "Add";
            this.buttonAddShape.UseVisualStyleBackColor = true;
            this.buttonAddShape.Click += new System.EventHandler(this.buttonAddShape_Click);
            // 
            // labelColor
            // 
            this.labelColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColor.Location = new System.Drawing.Point(12, 42);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(101, 23);
            this.labelColor.TabIndex = 2;
            this.labelColor.Text = "Color";
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Location = new System.Drawing.Point(119, 42);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeColor.TabIndex = 3;
            this.buttonChangeColor.Text = "Change";
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // FormAddShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 108);
            this.Controls.Add(this.buttonChangeColor);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.buttonAddShape);
            this.Controls.Add(this.comboBoxAvailableShapeTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddShape";
            this.Text = "Add shape";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAvailableShapeTypes;
        private System.Windows.Forms.Button buttonAddShape;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonChangeColor;
    }
}