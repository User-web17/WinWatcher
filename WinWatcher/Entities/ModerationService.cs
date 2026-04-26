using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WinWatcher.Entities
{
    public class ModerationService
    {
        private string[] blockedWords;
        private string[] blockedPrograms;
        private string logPath;

        private string currentBuffer = "";

        public ModerationService(string[] words, string[] programs, string path)
        {
            blockedWords = words;
            blockedPrograms = programs;
            logPath = path;
        }

        public void CheckKey(string key)
        {
            currentBuffer += key.ToLower();

            foreach (var word in blockedWords)
            {
                if (currentBuffer.Contains(word.ToLower()))
                {
                    File.AppendAllText(logPath,
                        $"Blocked word detected: {word} at {DateTime.Now}\n");

                    currentBuffer = "";
                }
            }

            if (currentBuffer.Length > 100)
                currentBuffer = "";
        }

        public void CheckProcesses()
        {
            var processes = Process.GetProcesses();

            foreach (var p in processes)
            {
                try
                {
                    if (blockedPrograms.Contains(p.ProcessName))
                    {
                        File.AppendAllText(logPath,
                            $"Blocked app closed: {p.ProcessName} at {DateTime.Now}\n");

                        p.Kill();
                    }
                }
                catch { }
            }
        }
    }
}
