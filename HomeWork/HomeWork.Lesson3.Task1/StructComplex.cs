namespace HomeWork.Lesson3.Task1
{
    internal struct StructComplex
    {
        internal double X { get; private set; }
        internal double Y { get; private set; }

        internal StructComplex(double x,double y)
        {
            X = x;
            Y = y;
        }
        internal StructComplex Addition(StructComplex newValue)
        {
            X += newValue.X;
            Y += newValue.Y;
            return this;
        }

        internal StructComplex Subtraction(StructComplex newValue)
        {
            X -= newValue.X;
            Y -= newValue.Y;
            return this;
        }

        internal new string ToString()
        {
            return string.Join(" ", Y,"+",X ,"^i");
        }
    }
}