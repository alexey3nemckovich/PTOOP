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
            this.toolStripLoadShape = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLoadShapeType = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonShapes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.toolStripButtonLoadShapeTypeRenderer = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddShape,
            this.toolStripLoadShape,
            this.toolStripButtonLoadShapeType,
            this.toolStripButtonLoadShapeTypeRenderer,
            this.toolStripSeparator2,
            this.toolStripButtonShapes,
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
            this.toolStripButtonAddShape.Click += new System.EventHandler(this.toolStripButtonAddShape_Click);
            // 
            // toolStripLoadShape
            // 
            this.toolStripLoadShape.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLoadShape.Image")));
            this.toolStripLoadShape.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLoadShape.Name = "toolStripLoadShape";
            this.toolStripLoadShape.Size = new System.Drawing.Size(87, 22);
            this.toolStripLoadShape.Text = "Load shape";
            this.toolStripLoadShape.Click += new System.EventHandler(this.toolStripLoadShape_Click);
            // 
            // toolStripButtonLoadShapeType
            // 
            this.toolStripButtonLoadShapeType.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoadShapeType.Image")));
            this.toolStripButtonLoadShapeType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadShapeType.Name = "toolStripButtonLoadShapeType";
            this.toolStripButtonLoadShapeType.Size = new System.Drawing.Size(113, 22);
            this.toolStripButtonLoadShapeType.Text = "Load shape type";
            this.toolStripButtonLoadShapeType.ToolTipText = "Load shape type";
            this.toolStripButtonLoadShapeType.Click += new System.EventHandler(this.toolStripButtonLoadShapeType_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonShapes
            // 
            this.toolStripButtonShapes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShapes.Image")));
            this.toolStripButtonShapes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShapes.Name = "toolStripButtonShapes";
            this.toolStripButtonShapes.Size = new System.Drawing.Size(64, 22);
            this.toolStripButtonShapes.Text = "Shapes";
            this.toolStripButtonShapes.Click += new System.EventHandler(this.toolStripButtonShapes_Click);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSettings.Image")));
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(69, 22);
            this.toolStripButtonSettings.Text = "Settings";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDraw.Location = new System.Drawing.Point(0, 28);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(708, 403);
            this.panelDraw.TabIndex = 1;
            this.panelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseDown);
            // 
            // toolStripButtonLoadShapeTypeRenderer
            // 
            this.toolStripButtonLoadShapeTypeRenderer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoadShapeTypeRenderer.Image")));
            this.toolStripButtonLoadShapeTypeRenderer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadShapeTypeRenderer.Name = "toolStripButtonLoadShapeTypeRenderer";
            this.toolStripButtonLoadShapeTypeRenderer.Size = new System.Drawing.Size(100, 22);
            this.toolStripButtonLoadShapeTypeRenderer.Text = "Load renderer";
            this.toolStripButtonLoadShapeTypeRenderer.ToolTipText = "Load shape type renderer";
            this.toolStripButtonLoadShapeTypeRenderer.Click += new System.EventHandler(this.toolStripButtonLoadShapeTypeRenderer_Click);
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
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadShapeType;
        private System.Windows.Forms.ToolStripButton toolStripLoadShape;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadShapeTypeRenderer;
    }
}

