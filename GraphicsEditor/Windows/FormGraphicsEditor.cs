using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using GraphicsEditor.Engine;

namespace GraphicsEditor.Windows
{
    public partial class FormGraphicsEditor : Form
    {
        private bool isDrawing;

        private Graphics g;
        private string shapeType;
        private List<Point> points;

        public FormGraphicsEditor()
        {
            InitializeComponent();

            isDrawing = false;
            points = new List<Point>();
        }

        private void toolStripButtonAddShape_Click(object sender, System.EventArgs e)
        {
            FormAddShape formAddShape = new FormAddShape();
            var result = formAddShape.ShowDialog();

            if (DialogResult.OK == result)
            {
                shapeType = formAddShape.SelectedShapeType;

                isDrawing = true;
            }
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

        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                points.Add(new Point(e.X, e.Y));

                if(points.Count == Editor.getInstance().Settings.GetCreatorForShapeType(shapeType).CountDefiningShapePoints())
                {
                    Editor.getInstance().CreateShape(shapeType, points);

                    RedrawPanel();
                }
            }
        }

        private void RedrawPanel()
        {
            g = panelDraw.CreateGraphics();

            List<Shapes.Shape> shapes = Editor.getInstance().ListOfShapes.Shapes;
            foreach (Shapes.Shape shape in shapes)
            {
                ShapeRenderers.IShapeRenderer shapeRenderer =
                    Editor.getInstance().Settings.GetRendererForShapeType(shape.TypeName);

                if (null != shapeRenderer)
                {
                    shapeRenderer.Render(g, shape);
                }
            }

            points.Clear();
            isDrawing = false;
        }
    }
}
