/*
 * Person   :   Dolgosheev Alexander
 * Date     :   05.12.2020
 *
 * Task     :   3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
 *                  Предусмотреть методы сложения, вычитания, умножения и деления дробей.
 *                  Написать программу, демонстрирующую все разработанные элементы класса.
 *
 *                  ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение  ArgumentException("Знаменатель не может быть равен 0");
 *                  Добавить упрощение дробей.
 */

using System;

namespace HomeWork.Lesson3.Task3
{
    internal class Program
    {
        private static void Main()
        {
            var fraction1 = new Fraction(1,3);
            var fraction2 = new Fraction(1,2);

            Console.WriteLine($"Дроби для анализа {fraction1.ToString()} & {fraction2.ToString()}\n");

            Console.WriteLine($"Сумма дробей : {fraction1.Operation(fraction2, Fraction.Operations.Addition).Result}");
            Console.WriteLine($"Разность дробей : {fraction1.Operation(fraction2, Fraction.Operations.Subtraction).Result}");
            Console.WriteLine($"Произведение дробей : {fraction1.Operation(fraction2, Fraction.Operations.Multiplication).Result}");
            Console.WriteLine($"Частное дробей : {fraction1.Operation(fraction2, Fraction.Operations.Division).Result}");

            Console.ReadKey();
        }
    }
}
