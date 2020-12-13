/*
 * Person   :   Dolgosheev Alexander
 * Date     :   13.12.2020
 *
 * Task     :   4. *а) Реализовать класс для работы с двумерным массивом. 
 *                      Реализовать конструктор, заполняющий массив случайными числами. 
                        Создать методы, которые 
                            возвращают сумму всех элементов массива, 
 *                          сумму всех элементов массива больше заданного, 
 *                      свойство, возвращающее минимальный элемент массива, 
 *                      свойство, возвращающее максимальный элемент массива, 
 *                      метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out)
 *                 *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
 *                  Дополнительные задачи
 *                  в) Обработать возможные исключительные ситуации при работе с файлами.
*/

using System;
using System.Text;

namespace HomeWork.Lesson4.Task4
{
    internal class Program
    {
        private static void Main()
        {
            var dom = new StringBuilder();
            var myArray = new MyArray();

            // Array show
            dom.Append("Array [,] ->");
            foreach (var i in myArray.GetArray)
                dom.Append($" {i}");

            // Summ
            dom.AppendLine($"\nСумма -> {myArray.Summ()}");

            // Summ more than
            var more = 8;
            dom.AppendLine($"Сумма чисел больше {more} -> {myArray.SummMoreThen(more)}");

            // Max
            dom.AppendLine($"Максимальный -> {myArray.Max}");

            // Min
            dom.AppendLine($"Минимальный -> {myArray.Min}");

            // Index of Max (out)
            myArray.IndexMax(out var result);
            if (!string.IsNullOrWhiteSpace(result))
                dom.AppendLine(result);

            Console.WriteLine(dom);

            var fileWorker = new FileWorker(dom);

            Console.WriteLine("\nLoad previous result from file ? y/N\n");
            if (Console.ReadKey().Key == ConsoleKey.Y)
                fileWorker.Read();

            Console.WriteLine("\nWrite current result to file ? y/N\n");
            if (Console.ReadKey().Key == ConsoleKey.Y)
                fileWorker.Write();
        }
    }
}
