using System;
using System.Collections;
using System.Linq;

namespace HomeWork.Lesson4.Task2
{
    internal class MyArray : IEnumerator, IEnumerable
    {
        private int _startValue;
        private readonly int _stepToFill;

        internal int[] GetArray;

        internal long Sum => GetArray.Sum();

        private int _position = -1;

        private MyArray(int size)
        {
            GetArray = new int[size];
        }

        public MyArray(int size, int startValue, int stepToFill)
        {
            GetArray = new int[size];
            _startValue = startValue;
            _stepToFill = stepToFill;

            if(GetArray!=null)
                FillArray();
        }

        public int this[int index]
        {
            set
            {
                if (index >= 0 && index < GetArray.Length)
                    GetArray[index] = value;
            }
            get
            {
                if (index >= 0 && index < GetArray.Length)
                    return GetArray[index];
                else
                    throw new IndexOutOfRangeException();
            }
        }

        private void FillArray()
        {
            for (var i = 0; i < GetArray.Length; i++)
            {
                GetArray[i] = i==0 ? _startValue : _startValue += _stepToFill;
            }
        }

        internal void Inverse()
        {
            for (var i = 0; i < GetArray.Length; i++)
            {
                GetArray[i] *= -1;
            }
        }

        internal void Multi(int x)
        {
            for (var i = 0; i < GetArray.Length; i++)
            {
                GetArray[i] *= x;
            }
        }

        internal MyArray Copy()
        {
            var returnArray = new MyArray(GetArray.Length);
            Array.Copy(GetArray, returnArray.GetArray, GetArray.Length);
            return returnArray;
        }

        internal MyArray Resize(int newSize)
        {
            Array.Resize(ref GetArray, newSize);
            return this;
        }

        internal MyArray Merge(MyArray array)
        {
            var tmpLength = GetArray.Length + array.Length;
            var returnArray = new MyArray(tmpLength);
            Array.Copy(GetArray,  returnArray.GetArray, GetArray.Length);
            Array.Copy(array.GetArray, 0, returnArray.GetArray,GetArray.Length , array.Length);
            return returnArray;
        }

        internal int MaxCount => GetArray.Max();

        internal int Length => GetArray.Length;

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            _position++;
            return (_position < Length);
        }

        public void Reset()
        {
            _position = 0;
        }

        public object Current => this[_position];
    }
}