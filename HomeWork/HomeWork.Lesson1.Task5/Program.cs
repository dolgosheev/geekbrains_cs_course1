/*
 * Person   :   Dolgosheev Alexander
 * Date     :   27.11.2020
 *
 * Task     :   5.
 *                  -   а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
 *                  -   б) Сделать задание, только вывод организуйте в центре экрана
 *                  -   в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)
 */

using System;

namespace HomeWork.Lesson1.Task5
{
    internal class Program
    {
        private static void Main()
        {
            var person = new Person("Alexander","Dolgosheev","Omsk");
            PrintCenter(person.GetPerson());
            Console.ReadKey();
        }

        private static void PrintCenter(string person)
        {
            Console.SetCursorPosition((Console.WindowWidth - person.Length) / 2, (Console.WindowHeight - 1) / 2);
            Console.WriteLine($"{person}");
        }
    }

    internal class Person
    {
        private string FirstName { get; }
        private string LasttName { get; }
        private string Town { get; }

        internal Person(string firstName,string lastName,string town)
        {
            FirstName = firstName;
            LasttName = lastName;
            Town = town;
        }

        internal string GetPerson()
        {
            var str = string.Format($"{FirstName} {LasttName} | {Town}");
            return str;
        }
    }
}
