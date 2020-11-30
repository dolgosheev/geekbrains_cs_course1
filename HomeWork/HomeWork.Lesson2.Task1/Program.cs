/*
 * Person   :   Dolgosheev Alexander
 * Date     :   29.11.2020
 *
 * Task     :   1. Написать метод, возвращающий минимальное из трех чисел.
 */

using System;

namespace HomeWork.Lesson2.Task1
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine($"Minimal is : {TripleMin(4, 2, 16)}");
            Console.ReadKey();
        }

        private static int TripleMin(int a,int b,int c)
        {
            var res = a < b ? a : b;
            return res < c ? res : c;
        }
    }
}
