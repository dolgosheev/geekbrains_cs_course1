using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HomeWork.Lesson7.Task1
{
    public class Doubler
    {
        public int Victory { get; private set; }
        private int _countSteps;
        public int Own { get; private set; } = 1;
        public Stack<int> History = new Stack<int>();

        public Doubler()
        {
            Victory = new Random().Next(10, 101);
            History.Push(Own);
        }

        public int Plus()
        {
            History.Push(++Own);
            return Own = History.Peek();
        }

        public int Multi()
        {
            History.Push(Own*= 2);
            return Own = History.Peek();
        }

        public int Back()
        {
            if(History.Count>1)
                Own = History.Pop();
            return Own = History.Peek();
        }

        public void CheckResult()
        {
            if(Own > Victory)
                MessageBox.Show($"Вы не справились, ваше число больше на {Own-Victory}", "Проигрыш");

            if (Own == Victory)
                MessageBox.Show($"Вы справились с {_countSteps} ходов", "Выигрыш!");
        }

        public int SummSteps()
        {
            return ++_countSteps;
        }
    }
}