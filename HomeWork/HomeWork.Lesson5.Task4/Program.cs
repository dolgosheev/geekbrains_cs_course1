/*
 * Person   :   Dolgosheev Alexander
 * Date     :   18.12.2020
 *
 * Task     :   4. Задача ЕГЭ.
*                  На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней
*                  школы. В первой строке сообщается количество учеников N, которое не меньше 10, но не
*                  превосходит 100, каждая из следующих N строк имеет следующий формат:
*                  <Фамилия> <Имя> <оценки>,
*                  где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не
*                  более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по
*                  пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом.
*                  Пример входной строки:
*                  Иванов Петр 4 5 3
*                  Требуется написать как можно более эффективную программу, которая будет выводить на экран
*                  фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
*                  набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
*                  Достаточно решить 2 задачи. Старайтесь разбивать программы на подпрограммы. Переписывайте в
*                  начало программы условие и свою фамилию. Все программы сделать в одном решении. Для решения
*                  задач используйте неизменяемые строки (string)
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace HomeWork.Lesson5.Task4
{
    internal class Program
    {
        private static void Main()
        {
            // read file
            var file = new FileWorker(@"grades9.txt");

            TeacherAnalizer.RawList = file.Stream;
            
            TeacherAnalizer.FillStudentsList();

            TeacherAnalizer.PrintWorst();

            Console.ReadKey();
        }
    }

    internal static class TeacherAnalizer
    {
        internal static List<string> RawList = new List<string>();
        internal static List<Student> StudentList = new List<Student>();

        private const string Pattern = @"^([а-яА-Я\w]{1,20})\s([а-яА-Я\w]{1,15})\s([1-5])\s([1-5])\s([1-5])$";

        internal static void PrintWorst()
        {
            StudentList.Sort((emp1, emp2) => emp1.Gpa.CompareTo(emp2.Gpa));
            for (int i = 0; i < 3; i++)
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
                {

                    continue;
                }

                IsStudent(RawList[i]);
            }
        }

        private static void IsStudent(string target)
        {
            var match = Regex.Match(target, Pattern, RegexOptions.IgnoreCase);
            while (match.Success)
            {
                var tmpfName = "";
                var tmplName = "";
                double tmpGpa = 0;

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

    internal class Student
    {
        internal string FirstName { get; }
        internal string LastName { get; }
        internal double Gpa { get; }

        public Student(string lname,string fname,double gpa)
        {
            FirstName = fname;
            LastName = lname;
            Gpa = gpa;
        }
    }

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
