using System;

namespace HomeWork.Lesson4.Task4
{
    internal static class Randomize
    {
        private static readonly Random Rnd = new Random();
        private static readonly int min = 1;
        private static readonly int max = 10;

        internal static int Get => Rnd.Next(min, max);
    }
}