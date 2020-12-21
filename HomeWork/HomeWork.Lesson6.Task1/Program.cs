/*
 * Person   :   Dolgosheev Alexander
 * Date     :   20.12.2020
 *
 * Task     :   1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double).
 *                 Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
*/

using System;

namespace HomeWork.Lesson6.Task1
{

    internal class Program
    {
        private static void Main()
        {
            Func<double, double, double> retFunc = InnerParams;

            var result1 = FromParams(2.2,3.4, retFunc);
            Console.WriteLine($"a * x ^ 2 = {result1}");

            var result2 = FromParams(7.2, 3.1, (a,x)=>a * Math.Sin(x));
            Console.WriteLine($"a * sin (x) = {result2}");

            Console.ReadKey();
        }

        private static double FromParams(double a, double x, Func<double, double, double> returnFucntion)
        {
            return returnFucntion(x, a);
        }

        private static double InnerParams(double a, double x)
        {
            return a * Math.Pow(x, 2);
        }
    }



}
