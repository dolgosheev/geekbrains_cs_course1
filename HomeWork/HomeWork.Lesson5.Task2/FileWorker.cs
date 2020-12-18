using System;
using System.IO;
using System.Text;

namespace HomeWork.Lesson5.Task2
{
    internal class FileWorker
    {
        private readonly string _file;
        internal StringBuilder Stream { get; } = new StringBuilder();

        public FileWorker(string file)
        {
            _file = file;
            Read();
        }

        private void Read()
        {
            if(string.IsNullOrWhiteSpace(_file))
                return;
            try
            {
                using (var sw = new StreamReader(_file))
                {
                    string line;
                    while ((line = sw.ReadLine()) != null)
                    {
                        Stream.AppendLine(line);
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