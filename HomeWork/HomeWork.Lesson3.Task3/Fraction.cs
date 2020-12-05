using System;

namespace HomeWork.Lesson3.Task3
{
    internal partial class Fraction
    {
        private long Denominator { get; set; }
        internal double Result { get;}

        private long NumeratorValue { get; set; }

        private long DenominatorValue
        {
            get => Denominator;
            set
            {
                if(value == 0)
                    throw new DivideByZeroException("Знаменатель не может быть равен 0");
                Denominator = value;
            }
        }

        internal Fraction(long numerator,long denominator)
        {
            if(numerator <0 && denominator <0)
                throw new ArgumentException("отрицательным может быть либо числитель либо знаменатель");

            NumeratorValue = numerator;
            DenominatorValue = denominator;

            Result = Math.Round( (double)NumeratorValue / DenominatorValue,3);
        }

        private long GetNod(long otherDenumerator)
        {
            long nod = 0;
            while (otherDenumerator != 0)
            {
                var tmp = otherDenumerator;
                otherDenumerator = DenominatorValue % otherDenumerator;
                nod = tmp;
            }

            return nod;
        }

        private long GetNok(long otherDenumerator)
        {
            return DenominatorValue * otherDenumerator / GetNod(otherDenumerator);
        }

        internal Fraction Operation(Fraction otherFraction,Operations operation)
        {
            var nok = GetNok(otherFraction.DenominatorValue);
            var multiplier1 = nok / DenominatorValue;
            var multiplier2 = nok / otherFraction.DenominatorValue;

            switch (operation)
            {
                case Operations.Addition:
                    return new Fraction(multiplier1 + multiplier2, nok);
                case Operations.Subtraction:
                    return new Fraction(multiplier1 - multiplier2, nok);
                case Operations.Multiplication:
                    return new Fraction(NumeratorValue*otherFraction.NumeratorValue,DenominatorValue*otherFraction.DenominatorValue);
                case Operations.Division:
                    var num = NumeratorValue * otherFraction.DenominatorValue;
                    var denum = DenominatorValue * otherFraction.NumeratorValue;
                    return new Fraction(num, num < 0 ? Math.Abs(denum) : denum );
                default:
                    return null;
            }
        }

        public new string ToString()
        {
            return string.Format($"{NumeratorValue}/{DenominatorValue}");
        }
    }
}