/*
 * Person   :   Dolgosheev Alexander
 * Date     :   26.11.2020
 *
 * Task     :   а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
 *                 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
 *                 Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
 *
 *              б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
 */

using System;
using System.Globalization;

namespace HomeWork.Lesson1.Task3
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Рассчёт расстояния между координатами\n\tВведите координаты первой точки по оси X : ");
            var sX1 = Console.ReadLine();
            Console.Write("\tВведите координаты первой точки по оси Y : ");
            var sY1 = Console.ReadLine();
            Console.Write("\tВведите координаты второй точки по оси X : ");
            var sX2 = Console.ReadLine();
            Console.Write("\tВведите координаты второй точки по оси Y : ");
            var sY2 = Console.ReadLine();

            double distance;

            #region a)

            //double.TryParse(sX1, out var iX1);
            //double.TryParse(sY1, out var iY1);
            //double.TryParse(sX2, out var iX2);
            //double.TryParse(sY2, out var iY2);



            //try
            //{
            //    distance = Math.Sqrt(Math.Pow(iX2 - iX1, 2) + Math.Pow(iY2 - iY1, 2));
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Деление на ноль недопустимо");
            //    distance = 0;
            //}

            #endregion

            #region b)

            distance = GetDistance(sX1, sY1, sX2, sY2);

            #endregion

            Console.WriteLine($"Расстояния между координатами {distance.ToString(CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }

        private static double GetDistance(string x1, string y1, string x2, string y2)
        {
            double distance;

            double.TryParse(x1, out var iX1);
            double.TryParse(y1, out var iY1);
            double.TryParse(x2, out var iX2);
            double.TryParse(y2, out var iY2);

            try
            {
                distance = Math.Sqrt(Math.Pow(iX2 - iX1, 2) + Math.Pow(iY2 - iY1, 2));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль недопустимо");
                return 0;
            }

            return distance;
        }
    }
}
