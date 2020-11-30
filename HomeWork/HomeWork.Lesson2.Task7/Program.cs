/*
 * Person   :   Dolgosheev Alexander
 * Date     :   30.11.2020
 *
 * Task     :   7.
 *                  a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
 *                  б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
 */

using System;

namespace HomeWork.Lesson2.Task7
{
    internal class Program
    {
        private static void Main()
        {
            SortMinToMax(1, 10);
            SortAndSummMinToMax(1,10);

            Console.ReadKey();
        }

        private static void SortMinToMax(int min, int max)
        {
            if (min < max)
                SortMinToMax(min, max - 1);

            Console.WriteLine(min < max ? max : min);
        }

        private static void SortAndSummMinToMax(int min, int max,int summ = 0)
        {
            if (min <= max)
            {
                summ += min < max ? max : min;
                SortAndSummMinToMax(min, max - 1, summ);
            }
            else
            {
                Console.WriteLine($"Сумма чисел : {summ}");
            }
        }
    }
}
