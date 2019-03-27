using System.Windows.Forms;

namespace SomeFriendPlugin
{
    public class FriendPlugin
    {
        public void DoSave(string message)
        {
            MessageBox.Show(
                "Some friend plugin on save:" + message,
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }

        public void DoLoad(string message)
        {
            MessageBox.Show(
                "Some friend plugin on load: " + message,
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
        }
    }
}
