using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6 };
            MyArray myArr = new MyArray(arr);

            var arr1 = myArr.Add(8);

            foreach (var element in arr1)
            {
                Console.Write("{0} ", element);
            }

            Console.WriteLine();
            Console.WriteLine(new MyArray(arr1).Contains(8));
            Console.WriteLine(new MyArray(arr1).GetByIndex(1));
        }
    }
}
