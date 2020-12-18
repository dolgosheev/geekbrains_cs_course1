using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HomeWork.Lesson5.Task2
{
    internal static class Message
    {
        internal static StringBuilder UsedText = new StringBuilder();

        internal static void NoMoreCharThan(int count)
        {
            var tmp = new StringBuilder();
            var pattern = @"[а-яА-Я\w]{"+ count + ",}";
            var match = Regex.Matches(UsedText.ToString(), pattern, RegexOptions.IgnoreCase);

            foreach (Match word in match)
            {
                tmp.AppendLine(word.ToString());
            }

            UsedText = tmp;
        }

        internal static void DeleteWordIfEndTo(char ch)
        {
            var pattern = @"[а-яА-Я\w]*"+ ch + "[\r\n]*";
            var match = Regex.Matches(UsedText.ToString(), pattern, RegexOptions.IgnoreCase);

            foreach (Match word in match)
            {
                UsedText.Replace(word.ToString(), string.Empty);
            }
        }

        internal static StringBuilder SearchLongestWord(int length = 1)
        {
            var ret = new StringBuilder();
            var result = Regex.Split(UsedText.ToString(), @"\n")
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .OrderBy(s => Tuple.Create(s, -s.Length))
                .ToList();

            ret.AppendLine($"Длиннейшие слова (вы указали {length})");
            for (var i = 0; i < length; i++)
            {
                try
                {
                    ret.AppendLine($" {result[i]}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return ret;
        }


    }
}