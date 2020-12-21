/*
 * Person   :   Dolgosheev Alexander
 * Date     :   21.12.2020
 *
 * Task     :   2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
 *                 а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
 *                 б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
 *                 в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HomeWork.Lesson6.Task2
{
    internal class Program
    {
        private static Func<double, double> _operation;

        private static void Main()
        {
            Console.Write("Введите начало интервала (double) : ");

            if (!double.TryParse(Console.ReadLine(), out var start))
                start = 0;

            Console.Write("Введите конец интервала (double) : ");

            if (!double.TryParse(Console.ReadLine(), out var finish))
                finish = 0;

            Console.Clear();


            var operationsDict = new Dictionary<string,Func<double,double>>
            {
                {"Нахождение синуса минимума функции",GetSin},
                {"Нахождение косинуса минимума функции",GetCos},
                {"Нахождение квадратного корня минимума функции",GetSqrt},

            };

            var activePosition = 0;
            var prefix = "* ";

            for (var i = 0; i < operationsDict.Count; i++)
            {
                if (i == activePosition)
                {
                    Console.WriteLine(prefix + operationsDict.ElementAt(i).Key);
                    continue;
                }

                Console.WriteLine(operationsDict.ElementAt(i).Key);
            }

            ConsoleKey k;
            while ((k = Console.ReadKey().Key) != ConsoleKey.Enter)
            {
                if (k == ConsoleKey.DownArrow && activePosition < operationsDict.Count - 1)
                {
                    activePosition++;
                }

                if (k == ConsoleKey.UpArrow && activePosition > 0)
                {
                    activePosition--;
                }

                Console.Clear();

                for (var i = 0; i < operationsDict.Count; i++)
                {
                    if (i == activePosition)
                    {
                        Console.WriteLine(prefix + operationsDict.ElementAt(i).Key);
                        continue;
                    }

                    Console.WriteLine(operationsDict.ElementAt(i).Key);
                }
            }


            Console.Write($"\nВыбрано - {operationsDict.ElementAt(activePosition).Key} | результат - ");
            _operation = operationsDict.ElementAt(activePosition).Value;

            SaveFunc("data.bin", start, finish, 1);
            Console.WriteLine(Load("data.bin"));

            Console.ReadKey();
        }

        public static double GetSin(double x)
        {
            return Math.Sin(x);
        }

        public static double GetCos(double x)
        {
            return Math.Cos(x);
        }

        public static double GetSqrt(double x)
        {
            return Math.Sqrt(x);
        }

        public static void SaveFunc(string fileName, double start, double counter, double step)
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                using (var bw = new BinaryWriter(fs))
                {
                    var x = start;
                    while (x <= counter)
                    {
                        bw.Write(  (double) _operation?.Invoke(x) );
                        x += step;
                    }
                }
            }
        }

        public static double Load(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var bw = new BinaryReader(fs))
                {
                    var min = double.MaxValue;
                    double d;
                    for (var i = 0; i < fs.Length / sizeof(double); i++)
                    {
                        d = bw.ReadDouble();
                        if (d < min)
                            min = d;
                    }
                    return min;
                }
            }
        }
    }
}
