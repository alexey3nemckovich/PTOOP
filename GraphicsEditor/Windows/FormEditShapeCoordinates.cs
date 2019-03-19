using System;
using System.Windows.Forms;
using GraphicsEditor.Shapes;
using System.Drawing;
using System.Collections.Generic;

namespace GraphicsEditor.Windows
{
    public partial class FormEditShapeCoordinates : Form
    {
        private Shape shape;

        public FormEditShapeCoordinates(Shape shape)
        {
            InitializeComponent();

            this.shape = shape;
            LoadData();
        }

        private void LoadData()
        {
            foreach(var point in shape.Points)
            {
                dataGridViewCoordinates.Rows.Add(point.X, point.Y);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<Point> points = new List<Point>();

                for(int i = 0; i < dataGridViewCoordinates.RowCount; i++)
                {
                    string xValue = dataGridViewCoordinates.Rows[i].Cells[0].Value.ToString();
                    string yValue = dataGridViewCoordinates.Rows[i].Cells[1].Value.ToString();
                    int x = int.Parse(xValue);
                    int y = int.Parse(yValue);

                    points.Add(new Point(x, y));
                }

                shape.Points = points.ToArray();

                MessageBox.Show(
                        "New coordinates saved",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                        ex.Message,//"Failed to load shape",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
    }
}
