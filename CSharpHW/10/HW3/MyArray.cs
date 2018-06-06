using System;

namespace HW3
{
    class MyArray
    {
        private readonly int[] _array;

        public MyArray(int[] arr)
        {
            _array = arr;
        }

        public int[] Add(int element)
        {
            var arr = new int[_array.Length+1];
            Array.Copy(_array, arr, _array.Length);
            arr[_array.Length] = element;
            return arr;
        }

        public bool Contains(int element)
        {
            foreach (var elem in _array)
            {
                if (elem == element)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetByIndex(int index)
        {
            return _array[index];
        }
    }
}
