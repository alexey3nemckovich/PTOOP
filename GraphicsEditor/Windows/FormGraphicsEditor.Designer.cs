namespace GraphicsEditor
{
    partial class FormGraphicsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGraphicsEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddShape = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShapes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddShape,
            this.toolStripButtonShapes,
            this.toolStripSeparator2,
            this.toolStripButtonSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(708, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAddShape
            // 
            this.toolStripButtonAddShape.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddShape.Image")));
            this.toolStripButtonAddShape.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddShape.Name = "toolStripButtonAddShape";
            this.toolStripButtonAddShape.Size = new System.Drawing.Size(83, 22);
            this.toolStripButtonAddShape.Text = "Add shape";
            // 
            // toolStripButtonShapes
            // 
            this.toolStripButtonShapes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShapes.Image")));
            this.toolStripButtonShapes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShapes.Name = "toolStripButtonShapes";
            this.toolStripButtonShapes.Size = new System.Drawing.Size(64, 22);
            this.toolStripButtonShapes.Text = "Shapes";
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSettings.Image")));
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(69, 22);
            this.toolStripButtonSettings.Text = "Settings";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDraw.Location = new System.Drawing.Point(0, 28);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(708, 403);
            this.panelDraw.TabIndex = 1;
            // 
            // FormGraphicsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 432);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormGraphicsEditor";
            this.Text = "Graphics Editor";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddShape;
        private System.Windows.Forms.ToolStripButton toolStripButtonShapes;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panelDraw;
    }
}

