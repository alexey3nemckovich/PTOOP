using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditor
{
    public partial class FormGraphicsEditor : Form
    {
        bool isDrawing = false;
        Graphics g;
        Point[] arrayPoints = new Point[3];
        int clicksNumber, currentClicks = 0;
        
        public FormGraphicsEditor()
        {
            InitializeComponent();
        }
    }
}
