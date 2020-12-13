using System;
using System.Linq;

namespace HomeWork.Lesson4.Task4
{
    internal class MyArray
    {
        internal int[,] GetArray;
        private readonly int _x = Randomize.Get;
        private readonly int _y = Randomize.Get;

        internal MyArray()
        {
            GetArray = new int[_x, _y];
            for (var i = 0; i < _x; i++)
            {
                for (var j = 0; j < _y; j++)
                {
                    GetArray[i, j] = Randomize.Get;
                }
            }
        }

        internal long Summ()
        {

            return GetArray.OfType<int>().Aggregate((x, y) => x + y);
        }

        internal long SummMoreThen(int more)
        {
            var result = 0;
            try
            {
                result = GetArray.OfType<int>().Where((x, y) => x > more && y > more)
                    .Aggregate((x, y) => x + y);
            }
            catch (Exception)
            {
                Console.WriteLine($"Чисел превышающих {more} нет");
            }
            return result;
        }

        internal void IndexMax(out string result)
        {
            result = "";
            try
            {
                var maxInfo = GetArray
                    .Cast<int>()
                    .Select((v, i) => Tuple.Create(v, i / GetArray.GetLength(1), i % GetArray.GetLength(1)))
                    .Max();

                result = string.Format($"Max element is {maxInfo.Item1} at [{maxInfo.Item2},{maxInfo.Item3}]");
            }
            catch (Exception)
            {
                Console.WriteLine("Нет таких значений");
            }
        }

        internal int Min => GetArray.OfType<int>().Min();
        internal int Max => GetArray.OfType<int>().Max();
    }
}