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
            string dllPath = "";
            if(selectFile("Dll files (*.dll)|*.dll", ref dllPath))
            {
                string newShapeTypeName = "";

                if(Editor.getInstance().LoadShapeType(dllPath, ref newShapeTypeName))
                {
                    MessageBox.Show(
                        "Successfully loaded new shape type '" + newShapeTypeName + "'",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show(
                        "Failed to load shape type from file '" + dllPath + "'",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private bool selectFile(string filter, ref string path)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = filter;
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void toolStripLoadShape_Click(object sender, System.EventArgs e)
        {
            string shapePath = "";
            if (selectFile("Shape files (*.shape)|*.shape", ref shapePath))
            {
                Editor.getInstance().LoadShape(shapePath);
            }
        }

        private void toolStripButtonLoadShapeTypeRenderer_Click(object sender, System.EventArgs e)
        {
            string dllPath = "";
            if (selectFile("Dll files (*.dll)|*.dll", ref dllPath))
            {
                string newRendererName = "";

                if(Editor.getInstance().LoadShapeTypeRenderer(dllPath, ref newRendererName))
                {
                    MessageBox.Show(
                        "Successfully loaded new renderer '" + newRendererName + "'",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show(
                        "Failed to load renderer  from file '" + dllPath + "'",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
