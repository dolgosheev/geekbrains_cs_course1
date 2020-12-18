/*
 * Person   :   Dolgosheev Alexander
 * Date     :   18.12.2020
 *
 * Task     :   3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
 *                  а) с использованием методов C#;
 *                  б) *разработав собственный алгоритм.
*/

using System;
using System.Linq;

namespace HomeWork.Lesson5.Task3
{
    internal class Program
    {
        private static void Main()
        {
            var a = "abcd";
            var b = "adcb";

            if(isEqual_self(a,b))
                Console.WriteLine("Одна строка является перестановкой другой");
            else
                Console.WriteLine("Одна строка не является перестановкой другой");

            Console.ReadKey();
        }

        private static bool isEqual_native(string a, string b)
        {
            var isEqual = a.Select(char.ToUpper).OrderBy(r => r).SequenceEqual(b.Select(char.ToUpper).OrderBy(r => r));
            if (isEqual)
                return true;

            return false;
        }

        private static bool isEqual_self(string x, string y)
        {
            var a = x.ToCharArray();
            var b = y.ToCharArray();

            Array.Sort(a);
            Array.Sort(b);

            if (new string(a) == new string(b))
                return true;

            return false;
        }

    }
}
