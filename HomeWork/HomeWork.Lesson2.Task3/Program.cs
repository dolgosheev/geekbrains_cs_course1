/*
 * Person   :   Dolgosheev Alexander
 * Date     :   29.11.2020
 *
 * Task     :   3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
 */

using System;

namespace HomeWork.Lesson2.Task3
{
    internal class Program
    {
        private static void Main()
        {
            string str;
            var sum = 0;
            Console.Write("Вводите числа, нажимайте Enter\nБудет посчитана сумма всех введенных нечетных положительных чисел\n\nДля завершения ввода и подсчета нажмите 0 (ноль) \n-> ");
            do
            {
                str = Console.ReadLine();
                Console.Write("-> ");

                if (int.TryParse(str, out var i))
                {
                    if( i>0 && i%2==0 )
                        sum += i;

                    continue;
                }

                if (string.IsNullOrWhiteSpace(str))
                    Console.WriteLine("Вы ничего не ввели, попробуйте еще...");
                else
                    Console.WriteLine("Это не число, попробуйте еще...");


                Console.Write("-> ");

            } while (str != "0");

            Console.WriteLine($"сумма - {sum}");

            Console.ReadKey();
        }
    }
}
