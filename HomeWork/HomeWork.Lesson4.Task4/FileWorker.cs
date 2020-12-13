using System;
using System.IO;
using System.Text;

namespace HomeWork.Lesson4.Task4
{
    internal class FileWorker
    {
        private const string File = @"MyArray.txt";
        private readonly StringBuilder _stream;

        public FileWorker(StringBuilder stream)
        {
            _stream = stream;
        }

        internal void Write()
        {
            try
            {
                using (var sw = new StreamWriter(File))
                    sw.Write(_stream);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Can't write | {e.Message}");
            }
        }

        internal void Read()
        {
            try
            {
                using (var sw = new StreamReader(File))
                {
                    string line;
                    while ((line = sw.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
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