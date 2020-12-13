/*
 * Person   :   Dolgosheev Alexander
 * Date     :   13.12.2020
 *
 * Task     :   2.
 *              а) Дописать класс MyArray для работы с одномерным массивом. 
 *                 Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом. 
 *                 
 *                 Создать свойство Sum, которые возвращают сумму элементов массива,
 *                 Метод Inverse,  меняющий знаки у всех элементов массива,
 *                 Метод Multi, умножающий каждый элемент массива на определенное число,
 *                 Cвойство MaxCount, возвращающее количество максимальных элементов,
 *                 Cоздать индексирующее свойство,
 *                 Cвойство Length, возвращающая длину массива, 
 *                 
 *                 метод Merge объединяющий два массива в один и возвращающий объединенный массив, 
 *                 
 *                 метод MyArray Copy(), возвращающий копию массива, 
 *                 
 *                 метод MyArray Resize(int newSize) изменяющий размер массива, 
 *                 
 *                 свойство GetArray с помощью которого можно получить ссылку на массив. 
 *                 
 *                 В Main продемонстрировать работу класса.
 *                 
 *                 б) *Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл
*/

using System;
using System.Text;

namespace HomeWork.Lesson4.Task2
{
    internal class Program
    {
        private static void Main()
        {
            var dom = new StringBuilder();

            // Array create and Fill
            var arrayClass = new MyArray(5,-5,5);

            // Array show
            dom.Append("Array ->");
            foreach (var i in arrayClass)
                dom.Append($" {i}");

            // Summ
            dom.AppendLine($"\nArray summ -> {arrayClass.Sum}");

            // Inverse
            arrayClass.Inverse();
            dom.Append("Array Inverse ->");
            foreach (var i in arrayClass.GetArray)
                dom.Append($" {i}");

            // Multi
            arrayClass.Multi(5);
            dom.Append("\nArray Multi *5 ->");
            foreach (var i in arrayClass.GetArray)
                dom.Append($" {i}");

            // MaxCount
            dom.AppendLine($"\nMax -> {arrayClass.MaxCount}");

            // Length
            dom.AppendLine($"Length -> {arrayClass.Length}");

            // Merge
            var arrayMerged = arrayClass.Merge( new MyArray(4,2,6) );
            dom.Append("Array Merged ->");
            foreach (var i in arrayMerged)
                dom.Append($" {i}");

            // Copy
            var arrayCopyed = arrayClass.Copy();
            dom.Append("\nArray Copyed ->");
            foreach (var i in arrayCopyed)
                dom.Append($" {i}");

            // Resize
            var arrayResize = arrayClass.Resize(2);
            dom.Append("\nArray Resized ->");
            foreach (var i in arrayResize.GetArray)
                dom.Append($" {i}");

            Console.WriteLine(dom);

            var fileWorker = new FileWorker(dom);
            
            Console.WriteLine("\nLoad previous result from file ? y/N\n");
            if(Console.ReadKey().Key == ConsoleKey.Y)
                fileWorker.Read();

            Console.WriteLine("\nWrite current result to file ? y/N\n");
            if (Console.ReadKey().Key == ConsoleKey.Y)
                fileWorker.Write();
        }
    }
}
