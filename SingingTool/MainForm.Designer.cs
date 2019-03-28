namespace SingingTool
{
    partial class FormSigningTool
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
            this.buttonSign = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonChooseFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSigningStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSign
            // 
            this.buttonSign.Enabled = false;
            this.buttonSign.Location = new System.Drawing.Point(289, 53);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(150, 60);
            this.buttonSign.TabIndex = 0;
            this.buttonSign.Text = "Sign";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(12, 12);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(373, 22);
            this.textBoxFilePath.TabIndex = 1;
            // 
            // buttonChooseFile
            // 
            this.buttonChooseFile.Location = new System.Drawing.Point(391, 12);
            this.buttonChooseFile.Name = "buttonChooseFile";
            this.buttonChooseFile.Size = new System.Drawing.Size(131, 23);
            this.buttonChooseFile.TabIndex = 2;
            this.buttonChooseFile.Text = "Choose file";
            this.buttonChooseFile.UseVisualStyleBackColor = true;
            this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(102, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Signing status:";
            // 
            // labelSigningStatus
            // 
            this.labelSigningStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSigningStatus.Location = new System.Drawing.Point(105, 83);
            this.labelSigningStatus.Name = "labelSigningStatus";
            this.labelSigningStatus.Size = new System.Drawing.Size(147, 30);
            this.labelSigningStatus.TabIndex = 4;
            // 
            // FormSigningTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 122);
            this.Controls.Add(this.labelSigningStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChooseFile);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonSign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSigningTool";
            this.Text = "Signing tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonChooseFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSigningStatus;
    }
}

