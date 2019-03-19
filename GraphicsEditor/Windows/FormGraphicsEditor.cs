using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using GraphicsEditor.Engine;
using GraphicsEditor.Shapes;

namespace GraphicsEditor.Windows
{
    public partial class FormGraphicsEditor : Form
    {
        private bool isDrawing;

        private Graphics g;
        private string shapeType;
        private Color shapeColor;
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
                shapeColor = formAddShape.SelectedColor;

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
                    Editor.getInstance().CreateShape(shapeType, points.ToArray(), shapeColor);

                    RedrawPanel();
                }
            }
        }

        private void RedrawPanel()
        {
            g = panelDraw.CreateGraphics();
            g.Clear(Color.White);

            var shapes = Editor.getInstance().ListOfShapes.Shapes;
            foreach (Shape shape in shapes)
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

        private void toolStripButtonPlugins_Click(object sender, System.EventArgs e)
        {
            FormPluginsSettings formPluginsSettings = new FormPluginsSettings();
            formPluginsSettings.ShowDialog();
        }
    }
}
