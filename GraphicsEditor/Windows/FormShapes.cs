using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GraphicsEditor.Engine;
using GraphicsEditor.Shapes;
using GraphicsEditor.Windows;

namespace GraphicsEditor
{
    public partial class FormShapes : Form
    {
        public enum ResultType
        {
            Ok,
            AddShape
        }

        public ResultType Result { get; private set; }

        public FormShapes()
        {
            InitializeComponent();

            LoadShapes();
        }

        private string ColorName(Color color)
        {
            string name = "Unknown";
            foreach (KnownColor kc in Enum.GetValues(typeof(KnownColor)))
            {
                Color known = Color.FromKnownColor(kc);
                if (color.ToArgb() == known.ToArgb())
                {
                    name = known.Name;
                }
            }

            return name;
        }

        private string ListOfPoints(List<Point> points)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < points.Count; i++)
            {
                sb.Append("(");
                sb.Append(points[i].X);
                sb.Append(", ");
                sb.Append(points[i].Y);
                sb.Append(")");

                if((points.Count - 1) != i)
                {
                    sb.Append(", ");
                }
            }

            return sb.ToString();
        }

        private void LoadShapes()
        {
            var shapes = Editor.getInstance().ListOfShapes.Shapes;

            for(int i = 0; i < shapes.Count; i++)
            {
                dataGridViewShapes.Rows.Add(
                    shapes[i].TypeName, ListOfPoints(shapes[i].Points), ColorName(shapes[i].Color));

                dataGridViewShapes.Rows[i].Tag = shapes[i];
            }
        }

        private void buttonAddShape_Click(object sender, EventArgs e)
        {
            Result = ResultType.AddShape;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonDeleteShape_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridViewShapes.SelectedRows)
            {
                Editor.getInstance().ListOfShapes.RemoveShape((Shape)row.Tag);
                dataGridViewShapes.Rows.RemoveAt(row.Index);
            }
        }

        private void buttonSaveShape_Click(object sender, EventArgs e)
        {
            string dirPath = "";
            if (Utils.selectFolder(ref dirPath))
            {
                foreach (DataGridViewRow row in dataGridViewShapes.SelectedRows)
                {
                    Shape shape = (Shape)row.Tag;

                    string filePath = "";
                    if(Editor.getInstance().SaveShape(shape, dirPath, ref filePath))
                    {
                        MessageBox.Show(
                            "Shape successfully stored to '" + filePath + "'",
                            "",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show(
                            "Failed to load save shape",
                            "",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonLoadShape_Click(object sender, EventArgs e)
        {
            Common.LoadShape();
        }

        private bool selectFolder(string filter, ref string path)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    path = fbd.SelectedPath;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
