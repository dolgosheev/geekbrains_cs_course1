/*
 * Person   :   Dolgosheev Alexander
 * Date     :   29.11.2020
 *
 * Task     :   2. Написать метод подсчета количества цифр числа.
 */


using System;

namespace HomeWork.Lesson2.Task2
{
    internal class Program
    {
        private static void Main()
        {
            var targetNum = 123123;
            Console.WriteLine($"Количество цифр числа {targetNum} = {CountDigitsAdvance(targetNum)}");
            Console.ReadKey();
        }

        private static int CountDigits(int digit)
        {
            return digit.ToString().Length;
        }

        public static int CountDigitsAdvance(int digit)
        {
            return (digit == 0) ? 1 : (int)Math.Log10(Math.Abs(digit)) + 1;
        }
    }
}
