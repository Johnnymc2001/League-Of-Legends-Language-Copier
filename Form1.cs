namespace LolCopyGUI
{
    public partial class Form1 : Form
    {
        string rootFolder = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            try
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderName = folderDialog.SelectedPath;
                    lblGameFolder.Text = folderName;
                    rootFolder = folderName;
                }
                cbLanguage.Items.Clear();
                cbLanguage.Items.AddRange(LolCopyLib.ParseLanguagesFile(rootFolder).ToArray());
                if (cbLanguage.Items.Count > 0)
                {
                    cbLanguage.SelectedIndex = 0;
                    btnGetLanguage.Enabled = true;
                }
                else btnGetLanguage.Enabled = false;
            }
            catch { }
        }

        private void btnGetLanguage_Click(object sender, EventArgs e)
        {
            List<String> files = new List<string>();

            files = Directory.GetFiles(rootFolder, $"*{cbLanguage.SelectedItem.ToString()}*", SearchOption.AllDirectories).ToList();
            LolCopyLib.CopyFile(files, cbLanguage.SelectedItem.ToString());
            MessageBox.Show($"Copied {files.Count} file!", "Success");
        }
    }
}