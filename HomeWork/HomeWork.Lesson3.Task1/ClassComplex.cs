using System;

namespace HomeWork.Lesson3.Task1
{
    internal class ClassComplex
    {
        private const string Ex1 = "Число может быть только положительным";

        private double _x;
        private double _y;

        internal double X
        {
            get => _x;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"\tОшибка присвоения x | {Ex1}");
                    _x = 0;
                    return;
                }
                    
                _x = value;
            }
        }

        internal double Y
        {
            get => _y;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"\tОшибка присвоения y | {Ex1}");
                    _y = 0;
                    return;
                }
                _y = value;
            }
        }

        internal ClassComplex(double x,double y)
        {
            X = x;
            Y = y;
        }

        internal ClassComplex Addition(ClassComplex newValue)
        {
            X += newValue.X;
            Y += newValue.Y;
            return this;
        }

        internal ClassComplex Subtraction(ClassComplex newValue)
        {
            X -= newValue.X;
            Y -= newValue.Y;
            return this;
        }

        internal ClassComplex Multiplication(ClassComplex newValue)
        {
            X *= newValue.X;
            Y *= newValue.Y;
            return this;
        }

        internal new string ToString()
        {
            return X > 0 && Y > 0 ? string.Join(" ", Y, "+", X, "^i") : "Ошибка операции";
        }
    }
}