using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Uniq(1, 2, 1, 3, 4, 3, 4));      
        }

        public static int Uniq(params int[] arr)
        {
            var result = arr[0];
            for(var i = 1; i < arr.Length; i++)
            {
                result ^= arr[i];
            }
            return result;
        }
    }
}
