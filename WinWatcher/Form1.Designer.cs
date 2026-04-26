namespace WinWatcher
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbControl = new TabControl();
            tabPage1 = new TabPage();
            btnSaveSettings = new Button();
            btnStartMonitoring = new Button();
            gbFileSettings = new GroupBox();
            btnBrowseFiles = new Button();
            txtFileName = new TextBox();
            lblReportFile = new Label();
            gbModerationSettings = new GroupBox();
            txtBlockedPrograms = new TextBox();
            lblBlockedPrograms = new Label();
            txtBlockedWords = new TextBox();
            lblBlockedWords = new Label();
            gbTrackingOptions = new GroupBox();
            cbEnableModeration = new CheckBox();
            cbEnableStatistics = new CheckBox();
            cbTrackApp = new CheckBox();
            cbTrackKeyboard = new CheckBox();
            tabPage2 = new TabPage();
            lblWarnings = new Label();
            lblAppsDetected = new Label();
            lblKeysLogged = new Label();
            btnStopMonitoring = new Button();
            lblMonitoring = new Label();
            pbMonitoringProgress = new ProgressBar();
            tabPage3 = new TabPage();
            gbAvailableReports = new GroupBox();
            btnOpenKeyLogFile = new Button();
            btnOpenModerationReport = new Button();
            btnOpenAppLogFile = new Button();
            tbControl.SuspendLayout();
            tabPage1.SuspendLayout();
            gbFileSettings.SuspendLayout();
            gbModerationSettings.SuspendLayout();
            gbTrackingOptions.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            gbAvailableReports.SuspendLayout();
            SuspendLayout();
            // 
            // tbControl
            // 
            tbControl.Controls.Add(tabPage1);
            tbControl.Controls.Add(tabPage2);
            tbControl.Controls.Add(tabPage3);
            tbControl.Location = new Point(1, 2);
            tbControl.Name = "tbControl";
            tbControl.SelectedIndex = 0;
            tbControl.Size = new Size(799, 446);
            tbControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnSaveSettings);
            tabPage1.Controls.Add(btnStartMonitoring);
            tabPage1.Controls.Add(gbFileSettings);
            tabPage1.Controls.Add(gbModerationSettings);
            tabPage1.Controls.Add(gbTrackingOptions);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(791, 413);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.Location = new Point(438, 274);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(178, 30);
            btnSaveSettings.TabIndex = 7;
            btnSaveSettings.Text = "Save Settings";
            btnSaveSettings.UseVisualStyleBackColor = true;
            btnSaveSettings.Click += btnSaveSettings_Click;
            // 
            // btnStartMonitoring
            // 
            btnStartMonitoring.Location = new Point(438, 238);
            btnStartMonitoring.Name = "btnStartMonitoring";
            btnStartMonitoring.Size = new Size(178, 30);
            btnStartMonitoring.TabIndex = 6;
            btnStartMonitoring.Text = "Start Monitoring";
            btnStartMonitoring.UseVisualStyleBackColor = true;
            btnStartMonitoring.Click += btnStartMonitoring_Click_1;
            // 
            // gbFileSettings
            // 
            gbFileSettings.Controls.Add(btnBrowseFiles);
            gbFileSettings.Controls.Add(txtFileName);
            gbFileSettings.Controls.Add(lblReportFile);
            gbFileSettings.Location = new Point(20, 208);
            gbFileSettings.Name = "gbFileSettings";
            gbFileSettings.Size = new Size(298, 143);
            gbFileSettings.TabIndex = 4;
            gbFileSettings.TabStop = false;
            gbFileSettings.Text = "File Settings";
            // 
            // btnBrowseFiles
            // 
            btnBrowseFiles.Location = new Point(167, 69);
            btnBrowseFiles.Name = "btnBrowseFiles";
            btnBrowseFiles.Size = new Size(94, 29);
            btnBrowseFiles.TabIndex = 5;
            btnBrowseFiles.Text = "Browse";
            btnBrowseFiles.UseVisualStyleBackColor = true;
            btnBrowseFiles.Click += btnBrowseFiles_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(18, 70);
            txtFileName.Name = "txtFileName";
            txtFileName.ReadOnly = true;
            txtFileName.Size = new Size(143, 27);
            txtFileName.TabIndex = 4;
            // 
            // lblReportFile
            // 
            lblReportFile.AutoSize = true;
            lblReportFile.Location = new Point(16, 40);
            lblReportFile.Name = "lblReportFile";
            lblReportFile.Size = new Size(116, 20);
            lblReportFile.TabIndex = 4;
            lblReportFile.Text = "Report file path:";
            // 
            // gbModerationSettings
            // 
            gbModerationSettings.Controls.Add(txtBlockedPrograms);
            gbModerationSettings.Controls.Add(lblBlockedPrograms);
            gbModerationSettings.Controls.Add(txtBlockedWords);
            gbModerationSettings.Controls.Add(lblBlockedWords);
            gbModerationSettings.Location = new Point(370, 19);
            gbModerationSettings.Name = "gbModerationSettings";
            gbModerationSettings.Size = new Size(337, 180);
            gbModerationSettings.TabIndex = 4;
            gbModerationSettings.TabStop = false;
            gbModerationSettings.Text = "Moderation Settings";
            // 
            // txtBlockedPrograms
            // 
            txtBlockedPrograms.Location = new Point(178, 56);
            txtBlockedPrograms.Multiline = true;
            txtBlockedPrograms.Name = "txtBlockedPrograms";
            txtBlockedPrograms.Size = new Size(132, 97);
            txtBlockedPrograms.TabIndex = 3;
            // 
            // lblBlockedPrograms
            // 
            lblBlockedPrograms.AutoSize = true;
            lblBlockedPrograms.Location = new Point(178, 30);
            lblBlockedPrograms.Name = "lblBlockedPrograms";
            lblBlockedPrograms.Size = new Size(132, 20);
            lblBlockedPrograms.TabIndex = 2;
            lblBlockedPrograms.Text = "Blocked Programs:";
            // 
            // txtBlockedWords
            // 
            txtBlockedWords.Location = new Point(16, 50);
            txtBlockedWords.Multiline = true;
            txtBlockedWords.Name = "txtBlockedWords";
            txtBlockedWords.Size = new Size(125, 103);
            txtBlockedWords.TabIndex = 1;
            // 
            // lblBlockedWords
            // 
            lblBlockedWords.AutoSize = true;
            lblBlockedWords.Location = new Point(16, 27);
            lblBlockedWords.Name = "lblBlockedWords";
            lblBlockedWords.Size = new Size(111, 20);
            lblBlockedWords.TabIndex = 0;
            lblBlockedWords.Text = "Blocked Words:";
            // 
            // gbTrackingOptions
            // 
            gbTrackingOptions.Controls.Add(cbEnableModeration);
            gbTrackingOptions.Controls.Add(cbEnableStatistics);
            gbTrackingOptions.Controls.Add(cbTrackApp);
            gbTrackingOptions.Controls.Add(cbTrackKeyboard);
            gbTrackingOptions.Location = new Point(20, 19);
            gbTrackingOptions.Name = "gbTrackingOptions";
            gbTrackingOptions.Size = new Size(298, 159);
            gbTrackingOptions.TabIndex = 0;
            gbTrackingOptions.TabStop = false;
            gbTrackingOptions.Text = "Tracking Options";
            // 
            // cbEnableModeration
            // 
            cbEnableModeration.AutoSize = true;
            cbEnableModeration.Location = new Point(16, 116);
            cbEnableModeration.Name = "cbEnableModeration";
            cbEnableModeration.Size = new Size(158, 24);
            cbEnableModeration.TabIndex = 3;
            cbEnableModeration.Text = "Enable Moderation";
            cbEnableModeration.UseVisualStyleBackColor = true;
            // 
            // cbEnableStatistics
            // 
            cbEnableStatistics.AutoSize = true;
            cbEnableStatistics.Location = new Point(16, 86);
            cbEnableStatistics.Name = "cbEnableStatistics";
            cbEnableStatistics.Size = new Size(197, 24);
            cbEnableStatistics.TabIndex = 2;
            cbEnableStatistics.Text = "Enable Statistics Logging";
            cbEnableStatistics.UseVisualStyleBackColor = true;
            // 
            // cbTrackApp
            // 
            cbTrackApp.AutoSize = true;
            cbTrackApp.Location = new Point(16, 56);
            cbTrackApp.Name = "cbTrackApp";
            cbTrackApp.Size = new Size(210, 24);
            cbTrackApp.TabIndex = 1;
            cbTrackApp.Text = "Track Running Applications";
            cbTrackApp.UseVisualStyleBackColor = true;
            // 
            // cbTrackKeyboard
            // 
            cbTrackKeyboard.AutoSize = true;
            cbTrackKeyboard.Location = new Point(16, 26);
            cbTrackKeyboard.Name = "cbTrackKeyboard";
            cbTrackKeyboard.Size = new Size(171, 24);
            cbTrackKeyboard.TabIndex = 0;
            cbTrackKeyboard.Text = "Track Keyboard Input";
            cbTrackKeyboard.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblWarnings);
            tabPage2.Controls.Add(lblAppsDetected);
            tabPage2.Controls.Add(lblKeysLogged);
            tabPage2.Controls.Add(btnStopMonitoring);
            tabPage2.Controls.Add(lblMonitoring);
            tabPage2.Controls.Add(pbMonitoringProgress);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(791, 413);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblWarnings
            // 
            lblWarnings.AutoSize = true;
            lblWarnings.Location = new Point(293, 226);
            lblWarnings.Name = "lblWarnings";
            lblWarnings.Size = new Size(85, 20);
            lblWarnings.TabIndex = 5;
            lblWarnings.Text = "Warnings: 0";
            // 
            // lblAppsDetected
            // 
            lblAppsDetected.AutoSize = true;
            lblAppsDetected.Location = new Point(293, 193);
            lblAppsDetected.Name = "lblAppsDetected";
            lblAppsDetected.Size = new Size(123, 20);
            lblAppsDetected.TabIndex = 4;
            lblAppsDetected.Text = "Apps Detected: 0";
            // 
            // lblKeysLogged
            // 
            lblKeysLogged.AutoSize = true;
            lblKeysLogged.Location = new Point(293, 160);
            lblKeysLogged.Name = "lblKeysLogged";
            lblKeysLogged.Size = new Size(103, 20);
            lblKeysLogged.TabIndex = 3;
            lblKeysLogged.Text = "Key Logged: 0";
            // 
            // btnStopMonitoring
            // 
            btnStopMonitoring.Location = new Point(293, 264);
            btnStopMonitoring.Name = "btnStopMonitoring";
            btnStopMonitoring.Size = new Size(165, 33);
            btnStopMonitoring.TabIndex = 2;
            btnStopMonitoring.Text = "Stop Monitoring";
            btnStopMonitoring.UseVisualStyleBackColor = true;
            // 
            // lblMonitoring
            // 
            lblMonitoring.AutoSize = true;
            lblMonitoring.Font = new Font("Segoe UI", 11F);
            lblMonitoring.Location = new Point(274, 69);
            lblMonitoring.Name = "lblMonitoring";
            lblMonitoring.Size = new Size(209, 25);
            lblMonitoring.TabIndex = 1;
            lblMonitoring.Text = "Monitoring is running...";
            // 
            // pbMonitoringProgress
            // 
            pbMonitoringProgress.Location = new Point(244, 113);
            pbMonitoringProgress.Name = "pbMonitoringProgress";
            pbMonitoringProgress.Size = new Size(261, 29);
            pbMonitoringProgress.Style = ProgressBarStyle.Marquee;
            pbMonitoringProgress.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(gbAvailableReports);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(791, 413);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbAvailableReports
            // 
            gbAvailableReports.Controls.Add(btnOpenKeyLogFile);
            gbAvailableReports.Controls.Add(btnOpenModerationReport);
            gbAvailableReports.Controls.Add(btnOpenAppLogFile);
            gbAvailableReports.Location = new Point(239, 91);
            gbAvailableReports.Name = "gbAvailableReports";
            gbAvailableReports.Size = new Size(250, 165);
            gbAvailableReports.TabIndex = 3;
            gbAvailableReports.TabStop = false;
            gbAvailableReports.Text = "Available Reports";
            // 
            // btnOpenKeyLogFile
            // 
            btnOpenKeyLogFile.Location = new Point(40, 37);
            btnOpenKeyLogFile.Name = "btnOpenKeyLogFile";
            btnOpenKeyLogFile.Size = new Size(170, 29);
            btnOpenKeyLogFile.TabIndex = 0;
            btnOpenKeyLogFile.Text = "Open Key Log File";
            btnOpenKeyLogFile.UseVisualStyleBackColor = true;
            // 
            // btnOpenModerationReport
            // 
            btnOpenModerationReport.Location = new Point(29, 107);
            btnOpenModerationReport.Name = "btnOpenModerationReport";
            btnOpenModerationReport.Size = new Size(192, 29);
            btnOpenModerationReport.TabIndex = 2;
            btnOpenModerationReport.Text = "Open Moderation Report";
            btnOpenModerationReport.UseVisualStyleBackColor = true;
            // 
            // btnOpenAppLogFile
            // 
            btnOpenAppLogFile.Location = new Point(40, 72);
            btnOpenAppLogFile.Name = "btnOpenAppLogFile";
            btnOpenAppLogFile.Size = new Size(170, 29);
            btnOpenAppLogFile.TabIndex = 1;
            btnOpenAppLogFile.Text = "Open App Log File";
            btnOpenAppLogFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbControl);
            Name = "Form1";
            Text = "Form1";
            tbControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            gbFileSettings.ResumeLayout(false);
            gbFileSettings.PerformLayout();
            gbModerationSettings.ResumeLayout(false);
            gbModerationSettings.PerformLayout();
            gbTrackingOptions.ResumeLayout(false);
            gbTrackingOptions.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            gbAvailableReports.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox gbTrackingOptions;
        private CheckBox cbEnableModeration;
        private CheckBox cbEnableStatistics;
        private CheckBox cbTrackApp;
        private CheckBox cbTrackKeyboard;
        private GroupBox gbModerationSettings;
        private GroupBox gbFileSettings;
        private TextBox txtBlockedPrograms;
        private Label lblBlockedPrograms;
        private TextBox txtBlockedWords;
        private Label lblBlockedWords;
        private TextBox txtFileName;
        private Label lblReportFile;
        private Button btnSaveSettings;
        private Button btnStartMonitoring;
        private Button btnBrowseFiles;
        private Label lblMonitoring;
        private ProgressBar pbMonitoringProgress;
        private Button btnStopMonitoring;
        private Label lblWarnings;
        private Label lblAppsDetected;
        private Label lblKeysLogged;
        private TabPage tabPage3;
        private GroupBox gbAvailableReports;
        private Button btnOpenKeyLogFile;
        private Button btnOpenModerationReport;
        private Button btnOpenAppLogFile;
    }
}
