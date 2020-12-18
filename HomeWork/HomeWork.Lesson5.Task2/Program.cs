/*
 * Person   :   Dolgosheev Alexander
 * Date     :   18.12.2020
 *
 * Task     :   Разработать класс Message, содержащий следующие статические методы для обработки текста:
 *              а) Вывести только те слова сообщения, которые содержат не более n букв.
 *              б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
 *              в) Найти самое длинное слово сообщения.
 *              г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
 *
 *              Продемонстрируйте работу программы на текстовом файле с вашей программой.
*/

using System;

namespace HomeWork.Lesson5.Task2
{
    internal class Program
    {
        private static void Main()
        {
            // read file
            var file = new FileWorker(@"Message.txt");
            // set start context for class
            Message.UsedText = file.Stream;
            // show word length then > 4 chars
            Message.NoMoreCharThan(4);
            // delete
            Message.DeleteWordIfEndTo('ь');

            // show result
            Console.WriteLine(Message.UsedText);

            // show longest (Default 1)
            var longest = Message.SearchLongestWord(3);
            Console.WriteLine(longest);
            Console.ReadKey();
        }
    }
}
