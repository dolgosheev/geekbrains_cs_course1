/*
 * Person   :   Dolgosheev Alexander
 * Date     :   21.12.2020
 *
 * Task     :   3. Переделать программу «Пример использования коллекций» для решения следующих задач:
 *                 а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
 *                 б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (частотный массив);
 *                 в) отсортировать список по возрасту студента;
 *                 г) *отсортировать список по курсу и возрасту студента;
 *                 д) разработать единый метод подсчета количества студентов по различным параметрам выбора с помощью делегата и методов предикатов.
 *
*/

using System;
using System.Collections.Generic;
using System.IO;

namespace HomeWork.Lesson6.Task3
{

    internal delegate bool Is(Student s);

    internal class Program
    {
        private static void Main()
        {
            var studentList = new List<Student>();
            var timestampDateTime = DateTime.Now;
            using (var sr = new StreamReader("students_4.csv"))
            {
                while (!sr.EndOfStream)
                {
                    try
                    {
                        var readedStrings = sr.ReadLine()?.Split(';');

                        var studentEntity = new Student(
                            readedStrings?[0],
                            readedStrings?[1],
                            readedStrings?[2],
                            readedStrings?[3],
                            readedStrings?[4],
                            int.Parse(readedStrings?[5] ?? string.Empty),
                            Convert.ToInt32(readedStrings?[6]),
                            int.Parse(readedStrings?[7] ?? string.Empty),
                            readedStrings?[8]
                            );

                        studentList.Add(studentEntity);

                        if (studentEntity.Course == 4)
                        {
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            studentList.Sort(ComparerFirstName);

            Console.WriteLine($"Всего студентов: {studentList.Count} человек");
            Console.WriteLine($"\t из них бакалавров: {CountStudents(studentList, IsBakalavr)}");
            Console.WriteLine($"\t из них магистров : {CountStudents(studentList, IsMagistr)}");
            Console.WriteLine($"\t из них старше 18 : {CountStudents(studentList, IsAgeBigger18)}");

            var specStudents = SpecialStudents(studentList, StageBetween18And20);

            Console.WriteLine($"\nСтуденты от 18 до 20");
            foreach (var course in specStudents)
            {
                course.Value.Sort(ComparerAge);
                Console.WriteLine($"\t из них на курсе {course.Key} : {course.Value.Count}");
            }

            Console.WriteLine($"\nВремя обработки документа - {DateTime.Now - timestampDateTime}");
            Console.ReadKey();
        }

        private static int ComparerFirstName(Student st1, Student st2)
        {
            return string.CompareOrdinal(st1.FirstName, st2.FirstName);
        }

        private static int ComparerAge(Student st1, Student st2)
        {
            if (st1.Age > st2.Age) return 1;
            if (st1.Age < st2.Age) return -1;
            return 0;
        }

        private static bool StageBetween18And20(Student student)
        {
            return student.Age >= 18 && student.Age <= 20;
        }

        private static bool IsAgeBigger18(Student student)
        {
            return student.Age > 18;
        }

        private static bool IsBakalavr(Student student)
        {
            return student.Course == 5;
        }

        private static bool IsMagistr(Student student)
        {
            return student.Course == 6;
        }

        private static int CountStudents(List<Student> students, Is @is)
        {
            var count = 0;
            foreach (var student in students)
            {
                if (@is(student)) count++;
            }
            return count;
        }

        private static Dictionary<int,List<Student>> SpecialStudents(List<Student> students, Is @is)
        {
            var studentaList = new Dictionary<int, List<Student>>
            {
                {1,new List<Student>()},
                {2,new List<Student>()},
                {3,new List<Student>()},
                {4,new List<Student>()},
                {5,new List<Student>()},
                {6,new List<Student>()}
            };


            foreach (var student in students)
            {
                if (@is(student))
                {
                    try
                    {
                        studentaList[student.Course].Add(student);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Course does not exist ! | {e.Message}");
                    }
                }
            }

            return studentaList;
        }
    }

    
}
