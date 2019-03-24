using System;
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

            dataGridViewShapes.CellContentClick +=
                new DataGridViewCellEventHandler(dataGridView_CellContentClick);
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

        private string ListOfPoints(Point[] points)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < points.Length; i++)
            {
                sb.Append("(");
                sb.Append(points[i].X);
                sb.Append(", ");
                sb.Append(points[i].Y);
                sb.Append(")");

                if((points.Length - 1) != i)
                {
                    sb.Append(", ");
                }
            }

            return sb.ToString();
        }

        private void LoadShapes()
        {
            var shapes = Editor.getInstance().ListOfShapes.Shapes;

            for(int i = 0; i < shapes.Length; i++)
            {
                dataGridViewShapes.Rows.Add(
                    shapes[i].TypeName, ListOfPoints(shapes[i].Points));

                DataGridViewButtonCell bc = dataGridViewShapes.Rows[i].Cells[2] as DataGridViewButtonCell;
                bc.FlatStyle = FlatStyle.Flat;
                bc.Style.BackColor = shapes[i].Color;
                //(dataGridViewShapes.Rows[i].Cells[2] as DataGridViewButtonCell).Style.CBackColor = shapes[i].Color;

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
            DataGridViewRow row = dataGridViewShapes.SelectedRows[0];

            Editor.getInstance().ListOfShapes.RemoveShape((Shape)row.Tag);
            dataGridViewShapes.Rows.RemoveAt(row.Index);
        }

        private void buttonSaveShapeList_Click(object sender, EventArgs e)
        {
            Common.SaveShapeList();
        }

        private void buttonLoadShapeList_Click(object sender, EventArgs e)
        {
            Common.LoadShapeList();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewShapes.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Shape shape = (Shape)dataGridViewShapes.Rows[e.RowIndex].Tag;

                if (1 == e.ColumnIndex)
                {
                    FormEditShapeCoordinates form = new FormEditShapeCoordinates(shape);
                    form.ShowDialog();

                    dataGridViewShapes.Rows[e.RowIndex].Cells[1].Value = ListOfPoints(shape.Points);
                }
                else
                {
                    if (DialogResult.OK == colorDialog.ShowDialog())
                    {
                        shape.Color = colorDialog.Color;
                        (dataGridViewShapes.Rows[e.RowIndex].Cells[2] as DataGridViewButtonCell).Style.BackColor = colorDialog.Color;
                    }
                }
            }
        }
    }
}
