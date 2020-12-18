/*
 * Person   :   Dolgosheev Alexander
 * Date     :   18.12.2020
 *
 * Task     :   1. Создать программу, которая будет проверять корректность ввода логина.
 *                 Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
 *
 *                 а) без использования регулярных выражений;
 *                 б) с использованием регулярных выражений.
*/

using System;

namespace HomeWork.Lesson5.Task1
{
    internal class Program
    {

        /// <summary>
        /// Вариант (заменить в while)
        ///         а) BoolRegexOff
        ///         б) BoolRegexOn
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Придумайте пароль \n\nУсловия\n2-10 линских символов\nЦифра не должна быть первой\n");
            do
            {
                Console.Write($"Попытка {++InputCheck.Try} : ");
            } while (InputCheck.BoolRegexOn(Console.ReadLine()));

            Console.WriteLine($"\nПодходит, справились с {InputCheck.Try} попытки");
            Console.ReadKey();
        }
    }
}
