using GraphicsEditor.Engine;
using GraphicsEditor.Shapes;
using System.Windows.Forms;

namespace GraphicsEditor.Windows
{
    class Common
    {

        public static void LoadShape()
        {
            string shapePath = "";
            if (Utils.selectFile("Shape files (*.shape)|*.shape", ref shapePath))
            {
                if (Editor.getInstance().LoadShape(shapePath))
                {
                    MessageBox.Show(
                        "Successfully loaded new shape",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show(
                        "Failed to load shape",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        public void SaveShape(Shape shape)
        {
            string dirPath = "";
            if (Utils.selectFolder(ref dirPath))
            {
                string filePath = "";
                if (Editor.getInstance().SaveShape(shape, dirPath, ref filePath))
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

        public static void LoadShapeType()
        {
            string dllPath = "";
            if (Utils.selectFile("Dll files (*.dll)|*.dll", ref dllPath))
            {
                string newShapeTypeName = "";

                if (Editor.getInstance().LoadShapeType(dllPath, ref newShapeTypeName))
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

        public static void LoadShapeTypeRenderer()
        {
            string dllPath = "";
            if (Utils.selectFile("Dll files (*.dll)|*.dll", ref dllPath))
            {
                string newRendererName = "";

                if (Editor.getInstance().LoadShapeTypeRenderer(dllPath, ref newRendererName))
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
