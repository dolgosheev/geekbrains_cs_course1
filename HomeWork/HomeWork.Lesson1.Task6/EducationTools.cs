using System;
using System.Text;

namespace HomeWork.Lesson1.Task6
{
    public static class EducationTools
    {
        public static void Pause()
        {
            Console.ReadKey();
        }

        public static void Print(params object[] args)
        {
            var result = new StringBuilder(); 
            foreach (var arg in args)
            {
                if (!string.IsNullOrWhiteSpace(arg.ToString()))
                {
                    result.Append($" {arg}");
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}