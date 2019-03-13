using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphicsEditor.Engine;

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
                Editor.getInstance().ListOfShapes.RemoveShape((Shapes.Shape)row.Tag);
                dataGridViewShapes.Rows.RemoveAt(row.Index);
            }
        }

        private void buttonSaveShape_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoadShape_Click(object sender, EventArgs e)
        {

        }
    }
}
