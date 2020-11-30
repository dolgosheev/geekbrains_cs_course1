/*
 * Person   :   Dolgosheev Alexander
 * Date     :   29.11.2020
 *
 * Task     :   6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
 *                  Хорошим называется число, которое делится на сумму своих цифр.
 *                  Реализовать подсчет времени выполнения программы, используя структуру DateTime.
 */

using System;
using System.Collections.Generic;

namespace HomeWork.Lesson2.Task6
{
    internal class Program
    {
        private static void Main()
        {
            var start = DateTime.Now;
            var goodDigitsList = new List<int>();

            for (var i = 1; i < 1000000000; i++)
            {
                if(i%NumSumm(i)==0)
                    goodDigitsList.Add(i);
            }

            var finish = DateTime.Now - start;

            Console.WriteLine($"Найдено {goodDigitsList.Count} хороших чисел за {finish}");
            

            Console.ReadKey();
        }


        private static List<int> IntToDigit(int num)
        {
            num = Math.Abs(num);
            var numbersList = new List<int>();
            while (num > 0)
            {
                var digit = num % 10;
                num /= 10;
                numbersList.Add(digit);
            }

            return numbersList;
        }

        private static int NumSumm(int num)
        {
            var sum = 0;
            foreach (var digit in IntToDigit(num))
            {
                sum += digit;
            }

            return sum;
        }

    }
}
