namespace WinWatcher
{
    public partial class Form1 : Form
    {
        private AppSettings settings = new AppSettings();

        private string keyLogPath;
        private string appLogPath;
        private string moderationLogPath;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnBrowseFiles_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = dialog.SelectedPath;
                }
            }
        }
        private void InitializeFilePaths()
        {
            if (string.IsNullOrEmpty(settings.ReportFolderPath))
                return;

            keyLogPath = Path.Combine(settings.ReportFolderPath, "keylog.txt");
            appLogPath = Path.Combine(settings.ReportFolderPath, "applog.txt");
            moderationLogPath = Path.Combine(settings.ReportFolderPath, "moderation.txt");
        }
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            settings.TrackKeyboard = cbTrackKeyboard.Checked;
            settings.TrackApps = cbTrackApp.Checked;
            settings.EnableStatistics = cbEnableStatistics.Checked;
            settings.EnableModeration = cbEnableModeration.Checked;

            settings.BlockedWords = txtBlockedWords.Text
                .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            settings.BlockedPrograms = txtBlockedPrograms.Text
                .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            settings.ReportFolderPath = txtFileName.Text;

            InitializeFilePaths();

            MessageBox.Show("Settings saved!");
        }

        private void btnStartMonitoring_Click_1(object sender, EventArgs e)
        {
            tbControl.SelectedIndex = 1;
        }
    }
}
