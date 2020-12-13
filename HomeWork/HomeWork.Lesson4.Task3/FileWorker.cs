using System;
using System.Collections.Generic;
using System.IO;

namespace HomeWork.Lesson4.Task3
{
    internal static class FileWorker
    {
        private const string File = @"Credentials.txt";


        internal static void Write(Dictionary<string,string> dictionary)
        {
            try
            {
                using (var sw = new StreamWriter(File))
                {
                    foreach (var dictPair in dictionary)
                    {
                        sw.Write($"{dictPair.Key}={dictPair.Value}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Can't write | {e.Message}");
            }
        }

        internal static Dictionary<string,string> DictionaryReadDocument()
        {
            var retDict = new Dictionary<string, string>();
            try
            {
                using (var sw = new StreamReader(File))
                {
                    
                    string line;
                    while ((line = sw.ReadLine()) != null)
                    {
                        var splString = line.Split('=');
                        if(splString.Length > 0 && !string.IsNullOrWhiteSpace(splString[1]))
                            retDict.Add(splString[0], splString[1]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Can't read | {e.Message}");
            }

            return retDict;
        }
    }
}