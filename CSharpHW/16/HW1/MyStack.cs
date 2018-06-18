using System;

namespace HW1
{
    class MyStack<T>
    {
        private T[] _array; 
        private const int DefaultCapacity = 10;
        public int Count { get; private set; }

        public MyStack()
        {
            Count = 0;
            _array = new T[DefaultCapacity];
        }

        public bool IsEmpty() 
        {
            return Count == 0;
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            var tmp = _array[Count-1];
            var newArray = new T[_array.Length];
            Array.Copy(_array, 0, newArray, 0, Count-1);
            _array = newArray;
            Count -= 1;
            return tmp;
        }

        public void Push(T newElement)
        {
            if (Count == _array.Length) 
            { 
                var newArray = new T[2 * _array.Length];
                Array.Copy(_array, 0, newArray, 0, Count);
                _array = newArray;
            }

            _array[Count++] = newElement; 
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            return _array[Count - 1];
        }

        public override string ToString()
        {
            var str = "";

            for (var i = 0; i < Count; i++)
            {
                str += _array[i] + " ";
            }

            return str;
        }
    }
}
