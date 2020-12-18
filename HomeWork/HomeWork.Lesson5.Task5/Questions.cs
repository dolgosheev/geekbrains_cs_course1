using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HomeWork.Lesson5.Task5
{
    internal static class Questions
    {
        internal static List<string> RawList = new List<string>();
        internal static List<QuestionEntity> QuestionsList = new List<QuestionEntity>();

        private const string Pattern = @"^(.*) \| (.*)$";

        internal static void FillEntities()
        {
            if (!RawList.Any())
                return;

            foreach (var parsedString in RawList)
            {
                ParseQuestion(parsedString);
            }
        }

        internal static List<QuestionEntity> GetQuestions(int count = 5)
        {
            return QuestionsList.OrderBy(r => Guid.NewGuid()).Take(count).ToList();
        }


        private static void ParseQuestion(string target)
        {
            var match = Regex.Match(target, Pattern, RegexOptions.IgnoreCase);
            while (match.Success)
            {
                var tmpQuestion = default(string);
                var tmpAnswer = default(string);

                for (var i = 1; i <= 5; i++)
                {
                    var group = match.Groups[i];
                    var cc = group.Captures;
                    for (var j = 0; j < cc.Count; j++)
                    {
                        var c = cc[j];

                        if (i == 1)
                        {
                            tmpQuestion = c.Value;
                            continue;
                        }

                        tmpAnswer = c.Value;
                    }
                }
                QuestionsList.Add(new QuestionEntity(tmpQuestion, tmpAnswer));
                match = match.NextMatch();
            }
        }

    }
}