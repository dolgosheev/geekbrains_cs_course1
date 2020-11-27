/*
 * Person   :   Dolgosheev Alexander
 * Date     :   26.11.2020
 *
 * Task     :   4. Написать программу обмена значениями двух переменных.
 *                  -   а) с использованием третьей переменной;
 *                  -   б) *без использования третьей переменной.
 */

using System;

namespace HomeWork.Lesson1.Task4
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Программа обмена значениями двух переменных\n\tВведите переменную A : ");
            var varA = Console.ReadLine();
            Console.Write("\tВведите переменную B : ");
            var varB = Console.ReadLine();

            Console.WriteLine($"\nПеременные \n\tvarA={varA}\n\tvarB={varB} ");

            // вариант через 3е значение
            var varC = varB;
            varB = varA;
            varA = varC;

            Console.WriteLine($"\nПоменяные переменные (через 3ю) \n\tvarA={varA}\n\tvarB={varB} ");

            // вариант через 2  переменные
            varA += varB;
            varB = varA.Replace(varB ?? string.Empty, "");
            varA = varA.Replace(varB, "");

            Console.WriteLine($"\nПоменяные переменные (через две) \n\tvarA={varA}\n\tvarB={varB} ");

            // вариант через 2 целочисленные переменные
            ReverseInt(varA, varB);

            Console.ReadKey();
        }

        static void ReverseInt(string x, string y)
        {
            int varA;
            int varB;
            // если числа целые можно без третей переменной
            try
            {
                varA = Convert.ToInt32(x);
                varB = Convert.ToInt32(y);
             
                varA ^= varB;
                varB ^= varA;
                varA ^= varB;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Введенные переменные не являются числами, нельзя реализовать без третьего параметра\nОшибка - {e.Message}");
                return;
            }
            Console.WriteLine($"\nПоменяные целочисленные переменные \n\tvarA={varA}\n\tvarB={varB} ");
        }
    }
}
