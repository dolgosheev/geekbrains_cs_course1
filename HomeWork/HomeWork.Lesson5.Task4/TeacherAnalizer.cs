using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HomeWork.Lesson5.Task4
{
    internal static class TeacherAnalizer
    {
        internal static List<string> RawList = new List<string>();
        internal static List<Student> StudentList = new List<Student>();

        private const string Pattern = @"^([а-яА-Я\w]{1,20})\s([а-яА-Я\w]{1,15})\s([1-5])\s([1-5])\s([1-5])$";

        internal static void PrintWorst(int count=3)
        {
            StudentList.Sort((emp1, emp2) => emp1.Gpa.CompareTo(emp2.Gpa));
            for (var i = 0; i < count; i++)
            {
                Console.WriteLine($"{StudentList[i].FirstName} {StudentList[i].LastName} | {StudentList[i].Gpa}");
            }
        }

        internal static void FillStudentsList()
        {
            if(!RawList.Any())
                return;

            for (var i = 0; i < RawList.Count; i++)
            {
                if (i == 0)
                    continue;

                IsStudent(RawList[i]);
            }
        }

        private static void IsStudent(string target)
        {
            var match = Regex.Match(target, Pattern, RegexOptions.IgnoreCase);
            while (match.Success)
            {
                var tmpfName = default(string);
                var tmplName = default(string);
                var tmpGpa = default(double);

                for (var i = 1; i <= 5; i++)
                {
                    var group = match.Groups[i];
                    var cc = group.Captures;
                    for (var j = 0; j < cc.Count; j++)
                    {
                        var c = cc[j];

                        if (i == 1)
                        {
                            tmpfName = c.Value;
                            continue;
                        }

                        if (i == 2)
                        {
                            tmplName = c.Value;
                            continue;
                        }

                        if (int.TryParse(c.Value, out var result))
                            tmpGpa += result;
                    }
                }
                StudentList.Add(new Student(tmplName, tmpfName, tmpGpa / 3));
                match = match.NextMatch();
            } 
        }
    }
}