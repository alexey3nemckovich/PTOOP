using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GraphicsEditor
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

        }

        private void toolStripButtonShapes_Click(object sender, System.EventArgs e)
        {

        }

        private void toolStripButtonSettings_Click(object sender, System.EventArgs e)
        {

        }

        public FormGraphicsEditor()
        {
            InitializeComponent();
        }
    }
}
