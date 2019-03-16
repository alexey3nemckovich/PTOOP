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
            onAddShape();
        }

        private void onAddShape()
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
            var result = formShapes.ShowDialog();

            RedrawPanel();

            if (DialogResult.OK == result)
            {
                if(FormShapes.ResultType.AddShape == formShapes.Result)
                {
                    onAddShape();
                }
            }
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
                if (MouseButtons.Left == e.Button)
                {
                    points.Add(new Point(e.X, e.Y));
                }

                int countDefiningPoints = 
                    Editor.getInstance().Settings.GetCreatorForShapeType(shapeType).CountDefiningShapePoints();

                if ((countDefiningPoints == points.Count) ||
                    (MouseButtons.Right == e.Button && -1 == countDefiningPoints && points.Count > 2))
                {
                    Editor.getInstance().CreateShape(shapeType, points);

                    RedrawPanel();
                }
            }
        }

        private void RedrawPanel()
        {
            g = panelDraw.CreateGraphics();
            g.Clear(Color.White);

            List<Shapes.Shape> shapes = Editor.getInstance().ListOfShapes.Shapes;
            foreach (Shapes.Shape shape in shapes)
            {
                ShapeRenderers.IShapeRenderer shapeRenderer =
                    Editor.getInstance().Settings.GetCurrentRendererForShapeType(shape.TypeName);

                if (null != shapeRenderer)
                {
                    shapeRenderer.Render(g, shape);
                }
            }

            points = new List<Point>();
            isDrawing = false;
        }

        private void toolStripButtonLoadShapeType_Click(object sender, System.EventArgs e)
        {
            Common.LoadShapeType();
        }

        private void toolStripLoadShape_Click(object sender, System.EventArgs e)
        {
            Common.LoadShape();

            RedrawPanel();
        }

        private void toolStripButtonLoadShapeTypeRenderer_Click(object sender, System.EventArgs e)
        {
            Common.LoadShapeTypeRenderer();
        }
    }
}
