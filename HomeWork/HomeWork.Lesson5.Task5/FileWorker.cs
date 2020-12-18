using System;
using System.Collections.Generic;
using System.IO;

namespace HomeWork.Lesson5.Task5
{
    internal class FileWorker
    {
        private readonly string _file;
        internal List<string> Stream { get; } = new List<string>();

        public FileWorker(string file)
        {
            _file = file;
            Read();
        }

        private void Read()
        {
            if (string.IsNullOrWhiteSpace(_file))
                return;
            try
            {
                using (var sw = new StreamReader(_file))
                {
                    string line;
                    while ((line = sw.ReadLine()) != null)
                    {
                        Stream.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Can't read | {e.Message}");
            }
        }
    }
}