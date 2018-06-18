using System;

namespace HW1
{
    class MyQueue<T>
    {
        private T[] _array;
        private int _size;
        private const int DefaultCapacity = 10; //The default size of array
        private int _capacity; //The size of array
        private readonly int _head; //The index of the first elem of the array

        public MyQueue()
        {
            _capacity = DefaultCapacity;
            _array = new T[DefaultCapacity];
            _size = 0;
            _head = 0;
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public void Enqueue(T newElement)
        {
            if (_size == _capacity)
            {
                var newQueue = new T[2 * _capacity];
                Array.Copy(_array, 0, newQueue, 0, _array.Length);
                _array = newQueue;
                _capacity *= 2;
            }
            _size++;
            _array[_size-1] = newElement;
        }

        public T Dequeue()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException();
            }
            var tmp = _array[_head];
            var newQueue = new T[_capacity];
            Array.Copy(_array, 1, newQueue, 0, _array.Length-1);
            _array = newQueue;
            _size--;
            return tmp;
        }

        public T Peek()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException();
            }
            return _array[_head];
        }

        public int Count()
        {
                return _size;
        }

        public override string ToString()
        {
            var str = "";
            for (var i = 0; i < _size; i++)
            {
                str += _array[i] + " ";
            }
            return str;
        }
    }
}

