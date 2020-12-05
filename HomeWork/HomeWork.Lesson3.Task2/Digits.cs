using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork.Lesson3.Task2
{
    internal static class Digits
    {
        private static string _inputString = default(string);
        private static readonly List<long> DigitsList = new List<long>();

        public static void StartInputDigits()
        {
            Console.WriteLine("Вводите числа");
            Console.WriteLine("\n\tВведите 0 для выхода и подсчета всех нечетных положительных чисел\n");
            do
            {
                Console.Write("-> ");
                _inputString = Console.ReadLine();
                if(IsSatisfied(_inputString,out var result))
                    DigitsList.Add(result);

            } while (_inputString != "0");

            Console.WriteLine($"\nПодходящие под условие числа {Summ(out var summ)}\nСумма подходящих под условие чисел {summ}");
        }

        private static bool IsSatisfied(string inputParam,out long result)
        {
            result = 0;
            if (string.IsNullOrWhiteSpace(inputParam))
            {
                Console.WriteLine("\tError : Ничего не введено | попробуйте еще");
                return false;
            }
                

            if (long.TryParse(inputParam, out result))
            {
                if (result % 2 != 0)
                {
                    return true;
                }

                Console.WriteLine("\tError : Число чётное | попробуйте еще");
                return false;
            }

            Console.WriteLine("\tError : Это не число | попробуйте еще");
            return false;
        }

        private static string Summ(out long result)
        {
            result = DigitsList.Sum(x => x);
            return  DigitsList.Count > 0 ? string.Join(",",DigitsList) : "отсутствуют" ;
        }
    }
}