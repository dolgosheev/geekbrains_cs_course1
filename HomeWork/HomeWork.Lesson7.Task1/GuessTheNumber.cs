using System;

namespace HomeWork.Lesson7.Task1
{
    public class GuessTheNumber
    {
        public int Victory { get; private set; }
        public int CountSteps { get; private set; } = 1;

        public GuessTheNumber()
        {
            Victory = new Random().Next(1, 101);
        }

        public int SummSteps()
        {
            return ++CountSteps;
        }

        public bool CheckResult(string val)
        {
            int.TryParse(val, out var own);

            return own == Victory;
        }
    }
}