/*
 * Person   :   Dolgosheev Alexander
 * Date     :   09.12.2020
 *
 * Task     :   1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
 *                 Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork.Lesson4.Task1
{
    internal static class Program
    {
        private static readonly Random Random = new Random();
        private const int Min = -10000;
        private const int Max = 10000;

        private static void Main()
        {
            var startList = GetListRandom(4);
            var countPairs = startList.Where(r => r % 3 == 0).ToList();

            Console.WriteLine(string.Concat("Generated List :\n\t", string.Join("\n\t", startList)));
            Console.WriteLine("Divided into 3 count : " + countPairs.Count());
            Console.WriteLine(countPairs.Count() > 0 ? string.Concat("It is :\n\t", string.Join("\n\t", countPairs)) : "");

            Console.ReadKey();
        }

        private static List<int> GetListRandom(int count)
        {
            var listRandom = new List<int>();
            while (count-- > 0)
            {
                listRandom.Add(GetGandom(Min, Max));
            }

            return listRandom;
        }

        private static int GetGandom(int min,int max)
        {
            return Random.Next(min, ++max);
        }
    }
}
