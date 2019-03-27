namespace GraphicsEditor.Windows
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonShapes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPlugins = new System.Windows.Forms.ToolStripButton();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddShape,
            this.toolStripSeparator2,
            this.toolStripButtonShapes,
            this.toolStripButtonSettings,
            this.toolStripSeparator1,
            this.toolStripButtonPlugins});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(944, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAddShape
            // 
            this.toolStripButtonAddShape.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddShape.Image")));
            this.toolStripButtonAddShape.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddShape.Name = "toolStripButtonAddShape";
            this.toolStripButtonAddShape.Size = new System.Drawing.Size(104, 24);
            this.toolStripButtonAddShape.Text = "Add shape";
            this.toolStripButtonAddShape.Click += new System.EventHandler(this.toolStripButtonAddShape_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonShapes
            // 
            this.toolStripButtonShapes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShapes.Image")));
            this.toolStripButtonShapes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShapes.Name = "toolStripButtonShapes";
            this.toolStripButtonShapes.Size = new System.Drawing.Size(80, 24);
            this.toolStripButtonShapes.Text = "Shapes";
            this.toolStripButtonShapes.Click += new System.EventHandler(this.toolStripButtonShapes_Click);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSettings.Image")));
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(86, 24);
            this.toolStripButtonSettings.Text = "Settings";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonPlugins
            // 
            this.toolStripButtonPlugins.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPlugins.Image")));
            this.toolStripButtonPlugins.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPlugins.Name = "toolStripButtonPlugins";
            this.toolStripButtonPlugins.Size = new System.Drawing.Size(80, 24);
            this.toolStripButtonPlugins.Text = "Plugins";
            this.toolStripButtonPlugins.Click += new System.EventHandler(this.toolStripButtonPlugins_Click);
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDraw.Location = new System.Drawing.Point(0, 34);
            this.panelDraw.Margin = new System.Windows.Forms.Padding(4);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(944, 496);
            this.panelDraw.TabIndex = 1;
            this.panelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseDown);
            // 
            // FormGraphicsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 532);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPlugins;
    }
}

