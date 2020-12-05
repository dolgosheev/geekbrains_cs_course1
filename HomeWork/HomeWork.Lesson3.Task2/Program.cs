﻿/*
 * Person   :   Dolgosheev Alexander
 * Date     :   05.12.2020
 *
 * Task     :   2.
 *                  а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
 *                     Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
 *                  б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
 *                     При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
 */

using System;

namespace HomeWork.Lesson3.Task2
{
    internal class Program
    {
        private static void Main()
        {
            Digits.StartInputDigits();
            Console.ReadKey();
        }
    }
}
