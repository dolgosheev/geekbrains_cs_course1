/*
 * Person   :   Dolgosheev Alexander
 * Date     :   26.11.2020
 *
 * Task     :   1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
 *                  -   а) используя склеивание;
 *                  -   б) используя форматированный вывод;
 *                  -   в) *используя вывод со знаком $.
 */

using System;

namespace HomeWork.Lesson1.Task1
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Анкета\n\tВведите имя : ");
            var firstName = Console.ReadLine();
            Console.Write("\tВведите фамилию : ");
            var lastNname = Console.ReadLine();
            Console.Write("\tВведите возраст : ");
            var age = Console.ReadLine();
            Console.Write("\tВведите рост : ");
            var growth = Console.ReadLine();
            Console.Write("\tВведите вес : ");
            var weight = Console.ReadLine();
            //Console.Write("\nВас зовут : " + firstName + " " + lastNname + "\nВаш возраст : " + age + "\nВаш рост : " + growth + "\nВаш вес : " + weight);
            //Console.Write("\nВас зовут : {0} {1}\nВаш возраст : {2}\nВаш рост : {3}\nВаш вес : {4}", firstName, lastNname, age, growth, weight);
            Console.Write($"\nВас зовут : {firstName} {lastNname}\nВаш возраст : {age}\nВаш рост : {growth}\nВаш вес : {weight}");
            Console.ReadKey();
        }
    }
}
