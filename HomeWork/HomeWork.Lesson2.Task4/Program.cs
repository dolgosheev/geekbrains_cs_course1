/*
 * Person   :   Dolgosheev Alexander
 * Date     :   29.11.2020
 *
 * Task     :   4. Реализовать метод проверки логина и пароля.
 *                 На вход подается логин и пароль.
 *                 На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
 *
 *                 Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
 *                 С помощью цикла do while ограничить ввод пароля тремя попытками.
 */


using System;
using System.Threading;

namespace HomeWork.Lesson2.Task4
{
    internal class Program
    {
        private static void Main()
        {
            bool access;
            Console.WriteLine("У Вас 3 попытки ввода логина и пароля\n");
            do
            {
                if (Auth.TryCount >=3 )
                {
                    Console.WriteLine("Вы исчерпали количество попыток...");
                    Thread.Sleep(3000);
                    return;
                }

                Console.Write("Введите логин и пароль для получения доступа\nЛогин : ");
                var login = Console.ReadLine();
                Console.Write("Пароль : ");
                var password = Console.ReadLine();
                access = Auth.TryAuthorise(login, password,out var reason);

                if(!string.IsNullOrWhiteSpace(reason))
                    Console.WriteLine($"\tОшибка - {reason}\n");

            } while (!access);

            Console.WriteLine($"Вы успешно авторизовались...");
            Console.ReadKey();

        }
    }

    internal static class Auth
    {
        internal static int TryCount { get; private set; }

        internal static bool TryAuthorise(string login, string password,out string reason)
        {
            if (++TryCount > 3)
            {
                reason = "Вы исчерпали количество попыток";
                return false;
            }

            if (string.IsNullOrWhiteSpace(login))
            {
                reason = "Логин пустой";
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                reason = "Пароль пустой";
                return false;
            }

            if (login != "root" && password != "GeekBrains")
            {
                reason = "Неправильыне логин либо пароль...";
                return false;
            }

            reason = "";
            return true;
        }
        
    }
}
