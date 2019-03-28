using System.Windows.Forms;
using Signing;

namespace SingingTool
{
    public partial class FormSigningTool : Form
    {

        private string filePath = "";

        public FormSigningTool()
        {
            InitializeComponent();
        }

        private void buttonSign_Click(object sender, System.EventArgs e)
        {
            if(Signer.getInstance().SignFile(filePath))
            {
                MessageBox.Show(
                    "File '" + filePath + "' was successfully signed",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);

                UpdateControls();
            }
            else
            {
                MessageBox.Show(
                    "Failed to sign file '" + filePath + "'",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonChooseFile_Click(object sender, System.EventArgs e)
        {
            string dllPath = "";
            if(Wnds.Utils.SelectDllFile(ref dllPath))
            {
                filePath = dllPath;

                UpdateControls();
            }
        }

        private void UpdateControls()
        {
            textBoxFilePath.Text = filePath;

            SigningStatus fileSigningStatus = Signer.getInstance().CheckSignatureForFile(filePath);

            string signingStatusText = "";
            switch (fileSigningStatus)
            {
                case SigningStatus.NOT_SIGNED:
                    {
                        signingStatusText = "Not signed";
                        buttonSign.Enabled = true;
                    }
                    break;
                case SigningStatus.INVALID_SIGNATURE:
                    {
                        signingStatusText = "Invalid signature";
                        buttonSign.Enabled = true;
                    }
                    break;
                case SigningStatus.VALIID_SIGNATURE:
                    {
                        signingStatusText = "Signed";
                        buttonSign.Enabled = false;
                    }
                    break;
            }

            labelSigningStatus.Text = signingStatusText;
        }

    }
}
