using Microsoft.VisualBasic;

namespace SimpleRestClient
{
    public partial class MainForm : Form
    {
        private const string fileFilter = "Request files (*.rqst)|*.rqst|All files (*.*)|*.*";
        public MainForm()
        {
            InitializeComponent();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new AboutForm();
            about.ShowDialog();
        }

        private void hideSidebarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
            hideSidebarToolStripMenuItem.Text = (splitContainer1.Panel1Collapsed ? "Show sidebar" : "Hide sidebar");
        }

        private void RequestTreeView_NodeDoubleClick(object sender, EventArgs e)
        {
            TreeNodeMouseClickEventArgs args = (TreeNodeMouseClickEventArgs)e;
            MessageBox.Show($"click-click on element {args.Node.Text}");
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = fileFilter;
            if (openFileDialog.ShowDialog() == DialogResult.OK )
            {
                MessageBox.Show($"Try to open {openFileDialog.FileName}");
            } else
            {
                MessageBox.Show($"Open canceled");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = fileFilter;
            if (saveFileDialog.ShowDialog()== DialogResult.OK )
            {
                MessageBox.Show($"Try to save {saveFileDialog.FileName}");
            } else
            {
                MessageBox.Show($"Save canceled");
            }
        }
    }

}