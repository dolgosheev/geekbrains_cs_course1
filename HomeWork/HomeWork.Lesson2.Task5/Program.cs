/*
 * Person   :   Dolgosheev Alexander
 * Date     :   29.11.2020
 *
 * Task     :   5. 
 *                 а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
 *                 б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
 */

using System;

namespace HomeWork.Lesson2.Task5
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Рассчёт ИМТ (индекс массы тела)\nВведите рост (в сантиметрах) : ");
            var growth = Console.ReadLine();
            Console.Write("Введите вес (в килограммах) : ");
            var weight = Console.ReadLine();

            var person = new Person(growth,weight);
            person.GetParams();

            Console.ReadKey();
        }
    }

    internal class Person
    {
        
        internal double Growth;
        internal double Weight;
        internal double Imt;

        public Person(string growth,string weight)
        {
            if (!string.IsNullOrWhiteSpace(growth) && double.TryParse(growth,out var iGrowth))
            {
                if(iGrowth >0) 
                    Growth = iGrowth/100;
            }

            if (!string.IsNullOrWhiteSpace(weight) && double.TryParse(weight, out var iWeight))
            {
                if (iWeight > 0)
                    Weight = iWeight;
            }

        }

        private bool CheckParams()
        {
            if (Growth > 0 && Weight > 0)
                return true;

            return false;
        }

        private void GetImt(out string result)
        {
            Imt = Convert.ToDouble((Weight / (Growth * Growth)).ToString("N3"));
            var correct = CorrectImt();


            switch (Imt)
            {
                case double d when (d <= 16):
                    result = String.Concat("Выраженный дефицит массы тела\n",correct);
                    break;
                case double d when (d > 16 && d <= 18.5):
                    result = String.Concat("Недостаточная (дефицит) масса тела\n",correct);
                    break;
                case double d when (d > 18.5 && d <=25):
                    result = String.Concat("Норма\n",correct);
                    break;
                case double d when (d > 25 && d <= 30):
                    result = String.Concat("Избыточная масса тела (предожирение)\n",correct);
                    break;
                case double d when (d > 30 && d <= 35):
                    result = String.Concat("Ожирение первой степени\n",correct);
                    break;
                case double d when (d > 35 && d <= 40):
                    result = String.Concat("Ожирение второй степени\n",correct);
                    break;
                case double d when (d > 40):
                    result = String.Concat("Ожирение третьей степени (морбидное)\n",correct);
                    break;
                default:
                    result = "Ошибка данных";
                    break;
            }
        }

        internal void GetParams()
        {
            if (!CheckParams())
            {
                Console.WriteLine("Некорректные параметры, попробуйте заново");
                return;
            }

            GetImt(out var result);
            Console.WriteLine($"\nВаши данные\n\nРост {Growth} м\nВес {Weight} кг\n\nИМТ {Imt}\n\nРекомендации - {result}");
        }

        internal string CorrectImt()
        {
            double xWeight;

            if (Imt > 0 && Imt < 18.5)
            {
                xWeight = (18.5 - Imt) * (Growth * Growth);
                return String.Format($"Доберите {xWeight.ToString("N3")} кг");
            }


            if (Imt > 25)
            {
                xWeight = (25 - Imt) * (Growth * Growth);
                return String.Format($"Скиньте {(Math.Abs(xWeight)).ToString("N3")} кг");
            }

            return "";
        }

    }
}
