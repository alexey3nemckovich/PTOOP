using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GraphicsEditor.Windows
{
    public partial class FormGraphicsEditor : Form
    {
        bool isDrawing = false;
        Graphics g;
        Point[] arrayPoints = new Point[3];
        List<Point> points;
        int count = 0;

        private void toolStripButtonAddShape_Click(object sender, System.EventArgs e)
        {
            FormAddShape formAddShape = new FormAddShape();
            formAddShape.ShowDialog();
        }

        private void toolStripButtonShapes_Click(object sender, System.EventArgs e)
        {
            FormShapes formShapes = new FormShapes();
            formShapes.ShowDialog();
        }

        private void toolStripButtonSettings_Click(object sender, System.EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.ShowDialog();
        }

        public FormGraphicsEditor()
        {
            InitializeComponent();
        }
    }
}
