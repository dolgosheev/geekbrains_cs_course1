/*
 * Person   :   Dolgosheev Alexander
 * Date     :   18.12.2020
 *
 * Task     :   5. **Написать игру «Верю. Не верю». В файле хранятся вопрос и ответ, правда это или нет.
*                  Например: «Шариковую ручку изобрели в древнем Египте», «Да».
*                  Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задаёт их игроку.
*                  Игрок отвечает Да или Нет на каждый вопрос и набирает баллы за каждый правильный ответ.
*                  Список вопросов ищите во вложении или воспользуйтесь интернетом.
*/

using System;

namespace HomeWork.Lesson5.Task5
{
    internal class Program
    {
        private static void Main()
        {
            // read file
            var file = new FileWorker(@"YesNo.txt");

            // fill all lines
            Questions.RawList = file.Stream;

            // complete entities QuestionEntity
            Questions.FillEntities();

            Console.WriteLine("Игра верю не верю\nПравила :\n\tваша задача - отвечать на вопросы Y (да) или N (нет)\n\n");

            var questions = Questions.GetQuestions();


            foreach (var question in questions)
            {
                Console.Write("\nВопрос : ");
                Console.Write($"{question.Question} y/N\n");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    if (question.Answer == "Да")
                        Console.WriteLine("\tОтвет верный");
                    else
                        Console.WriteLine("\tОтвет не верный");
                }
                else
                {
                    if (question.Answer == "Нет")
                        Console.WriteLine("\tОтвет верный");
                    else
                        Console.WriteLine("\tОтвет не верный");
                }
            }

            Console.ReadKey();
        }
    }
}
