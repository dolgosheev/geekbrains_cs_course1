﻿/*
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

namespace HomeWork.Lesson5.Task4
{
    internal class Program
    {
        private static void Main()
        {
            // read file
            var file = new FileWorker(@"grades9.txt");

            // Fill raw data
            TeacherAnalizer.RawList = file.Stream;
            
            // Fill List of Students Entity
            TeacherAnalizer.FillStudentsList();

            // Print n-th worst students (Default 3)
            TeacherAnalizer.PrintWorst();

            Console.ReadKey();
        }
    }
}
