using WinWatcher.Entities;

namespace WinWatcher
{
    public partial class Form1 : Form
    {
        private AppSettings settings = new AppSettings();

        private string keyLogPath;
        private string appLogPath;
        private string moderationLogPath;
        private KeyboardTracker keyboardTracker;
        private ProcessTracker processTracker;
        private ModerationService moderationService;
        private System.Windows.Forms.Timer moderationTimer;
        private int allowedTabIndex = 0;
        private int keyCount = 0;
        private int appCount = 0;
        private int warningCount = 0;

        public Form1()
        {
            InitializeComponent();
            cbEnableModeration.CheckedChanged += cbEnableModeration_CheckedChanged;
            tbControl.Selecting += tbControl_Selecting;
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

        private void btnStartMonitoring_Click(object sender, EventArgs e)
        {
            allowedTabIndex = 1;
            tbControl.SelectedIndex = 1;

            lblMonitoring.Text = "Monitoring is running...";
            pbMonitoringProgress.Style = ProgressBarStyle.Marquee;

            Directory.CreateDirectory(settings.ReportFolderPath);

            if (settings.TrackKeyboard)
            {
                keyboardTracker = new KeyboardTracker(keyLogPath, OnKeyPressed);
                keyboardTracker.Start();
            }

            if (settings.TrackApps)
            {
                processTracker = new ProcessTracker(appLogPath);
                processTracker.Start();
            }

            if (settings.EnableModeration)
            {
                moderationService = new ModerationService(
                    settings.BlockedWords,
                    settings.BlockedPrograms,
                    moderationLogPath);

                moderationTimer = new System.Windows.Forms.Timer();
                moderationTimer.Interval = 3000;
                moderationTimer.Tick += (s, ev) =>
                {
                    moderationService.CheckProcesses();
                };
                moderationTimer.Start();
            }
        }
        private void btnStopMonitoring_Click(object sender, EventArgs e)
        {
            lblMonitoring.Text = "Monitoring stopped...";
            pbMonitoringProgress.Style = ProgressBarStyle.Blocks;

            keyboardTracker?.Stop();
            processTracker?.Stop();
            moderationTimer?.Stop();

            allowedTabIndex = 2;

            tbControl.SelectedIndex = 2;

            UpdateReportButtons();
        }
        private void UpdateReportButtons()
        {
            btnOpenKeyLogFile.Enabled =
                settings.EnableStatistics &&
                settings.TrackKeyboard &&
                File.Exists(keyLogPath);

            btnOpenAppLogFile.Enabled =
                settings.EnableStatistics &&
                settings.TrackApps &&
                File.Exists(appLogPath);

            btnOpenModerationReport.Enabled =
                settings.EnableModeration &&
                File.Exists(moderationLogPath);
        }

        private void btnOpenKeyLogFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(keyLogPath))
                System.Diagnostics.Process.Start("notepad.exe", keyLogPath);
        }

        private void btnOpenAppLogFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(appLogPath))
                System.Diagnostics.Process.Start("notepad.exe", appLogPath);
        }

        private void btnOpenModerationReport_Click(object sender, EventArgs e)
        {
            if (File.Exists(moderationLogPath))
                System.Diagnostics.Process.Start("notepad.exe", moderationLogPath);
        }
        private void cbEnableModeration_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = cbEnableModeration.Checked;

            txtBlockedWords.Enabled = enabled;
            txtBlockedPrograms.Enabled = enabled;
        }
        private void OnKeyPressed(string key)
        {
            keyCount++;
            lblKeysLogged.Text = $"Keys logged: {keyCount}";

            int before = warningCount;

            moderationService?.CheckKey(key);

            if (File.Exists(moderationLogPath))
            {
                int lines = File.ReadAllLines(moderationLogPath).Length;
                if (lines > warningCount)
                {
                    warningCount = lines;
                    lblWarnings.Text = $"Warnings: {warningCount}";
                }
            }
        }
        private void tbControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex > allowedTabIndex)
                e.Cancel = true;
        }
    }
}
