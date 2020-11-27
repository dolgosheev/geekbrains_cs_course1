/*
 * Person   :   Dolgosheev Alexander
 * Date     :   26.11.2020
 *
 * Task     :   2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
 */

using System;
using System.Globalization;

namespace HomeWork.Lesson1.Task2
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Рассчёт ИМТ (индекс массы тела)\n\tВведите рост человека ( рост в метрах ) : ");
            var sGrowth = Console.ReadLine();
            Console.Write("\tВведите вес человека (масса тела в килограммах) : ");
            var sWeight = Console.ReadLine();

            byte.TryParse(sGrowth, out var iGrowth);
            byte.TryParse(sWeight, out var iWeight);

            int imt;
            try
            {
                imt = iWeight / (iGrowth * iGrowth);
                Console.WriteLine($"Индекс массы тела (ИМТ) {imt.ToString(CultureInfo.InvariantCulture)}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Вы ввели некорректное значение. Рост и вес должны быть > 0");
            }

            Console.ReadKey();
        }
    }
}
