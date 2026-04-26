using System;
using System.Collections.Generic;
using System.Text;

namespace WinWatcher.Entities
{
    public class AppSettings
    {
        public bool TrackKeyboard { get; set; }
        public bool TrackApps { get; set; }
        public bool EnableStatistics { get; set; }
        public bool EnableModeration { get; set; }

        public string[] BlockedWords { get; set; }
        public string[] BlockedPrograms { get; set; }

        public string ReportFolderPath { get; set; }
    }
}
