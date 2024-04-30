using System.Diagnostics;

namespace AppsLauncher
{
    public partial class frmLauncher : Form
    {
        public frmLauncher()
        {
            InitializeComponent();
        }

        private void picNotepad_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void picPaint_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");
        }

        private void picWord_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Program Files (x86)\\Microsoft Office\\root\\Office16\\WINWORD.EXE");
        }

        private void picCMD_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe");
        }

        private void picChrome_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", "https://fortifiedcitymyanmar.com/?page_id=182");
        }

        private void picFileExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("explorer");
        }
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
