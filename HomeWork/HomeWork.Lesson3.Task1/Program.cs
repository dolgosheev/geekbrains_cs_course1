/*
 * Person   :   Dolgosheev Alexander
 * Date     :   05.12.2020
 *
 * Task     :   1.
 *                  а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
 *                  б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
 */

using System;

namespace HomeWork.Lesson3.Task1
{
    internal class Program
    {
        private static void Main()
        {

            double a = 2;
            double b = 3;
            double c = 1;
            double d = 4;

            #region Работа со структурой

            Console.WriteLine("Работа со структурой");
            var structComplexDigit1 = new StructComplex(a,b);
            var structComplexDigit2 = new StructComplex(c,d);

            Console.WriteLine($"\tСумма : {(structComplexDigit1.Addition(structComplexDigit2)).ToString()}");


            var structComplexDigit3 = new StructComplex(a, b);
            var structComplexDigit4 = new StructComplex(c, d);

            Console.WriteLine($"\tРазность : {(structComplexDigit3.Subtraction(structComplexDigit4)).ToString()}");

            #endregion

            #region Работа с классом

            Console.WriteLine("\nРабота с классом");
            var classComplexDigit1 = new ClassComplex(a, b);
            var classComplexDigit2 = new ClassComplex(c, d);

            Console.WriteLine($"\tСумма : {(classComplexDigit1.Addition(classComplexDigit2)).ToString()}");

            var classComplexDigit3 = new ClassComplex(a, b);
            var classComplexDigit4 = new ClassComplex(c, d);

            Console.WriteLine($"\tРазность : {(classComplexDigit3.Subtraction(classComplexDigit4)).ToString()}");

            var classComplexDigit5 = new ClassComplex(a, b);
            var classComplexDigit6 = new ClassComplex(c, d);

            Console.WriteLine($"\tПроизведение : {(classComplexDigit5.Multiplication(classComplexDigit6)).ToString()}");

            #endregion

            Console.ReadKey();
        }

    }
}
