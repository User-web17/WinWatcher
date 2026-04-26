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
            string processedKey = ProcessKey(key);

            if (string.IsNullOrEmpty(processedKey))
                return;

            currentBuffer += processedKey;

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
        private string ProcessKey(string key)
        {
            if (key.Length == 1)
                return key.ToLower();

            if (key == "Space")
                return " ";

            if (key.StartsWith("D") && key.Length == 2)
                return key[1].ToString(); // D1 → "1"

            return "";
        }

        public void CheckProcesses()
        {
            var processes = Process.GetProcesses();

            foreach (var p in processes)
            {
                try
                {
                    if (blockedPrograms.Any(bp =>
    bp.Equals(p.ProcessName, StringComparison.OrdinalIgnoreCase)))
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
