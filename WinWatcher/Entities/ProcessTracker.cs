using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Timers;

namespace WinWatcher.Entities
{
    public class ProcessTracker
    {
        private System.Timers.Timer timer;
        private string logPath;

        public ProcessTracker(string path)
        {
            logPath = path;
            timer = new System.Timers.Timer(3000);
            timer.Elapsed += CheckProcesses;
        }

        public void Start() => timer.Start();
        public void Stop() => timer.Stop();

        private void CheckProcesses(object sender, ElapsedEventArgs e)
        {
            var processes = Process.GetProcesses();

            foreach (var p in processes)
            {
                try
                {
                    File.AppendAllText(logPath,
                        $"{DateTime.Now}: {p.ProcessName}\n");
                }
                catch { }
            }
        }
    }
}
