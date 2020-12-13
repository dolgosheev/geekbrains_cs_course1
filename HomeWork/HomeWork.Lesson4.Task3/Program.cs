/*
 * Person   :   Dolgosheev Alexander
 * Date     :   13.12.2020
 *
 * Task     :   3. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив.
 *                 Создайте структуру Account, содержащую Login и Password.
*/

using System;
using System.Collections.Generic;

namespace HomeWork.Lesson4.Task3
{
    internal class Program
    {
        private static void Main()
        {
            // First -> fill Credentials.txt any data
            #region fill data

            var data = new Dictionary<string,string>
            {
                {"admin","pa$$w0rd"},
                {"user","qwerty"},
                {"moderator","A12345!"}
            };
            FileWorker.Write(data);

            #endregion

            // Try to get Account "admin" and create struct from his credentials
            var searchLogin = "admin";
            var adminAcc = new Account(FileWorker.DictionaryReadDocument(), searchLogin);

            if(!string.IsNullOrWhiteSpace(adminAcc.Login))
                Console.WriteLine($"Hello login->[{adminAcc.Login}] password->[{adminAcc.Password}]");
            else
                Console.WriteLine($"Unfortunatelly, login \"{searchLogin}\" has not found ");
            Console.ReadKey();
        }
    }
}
