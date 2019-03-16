using System.Windows.Forms;

namespace GraphicsEditor.Windows
{
    class Utils
    {
        public static bool selectFile(string filter, ref string path)
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

        public static bool selectFolder(ref string path)
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
