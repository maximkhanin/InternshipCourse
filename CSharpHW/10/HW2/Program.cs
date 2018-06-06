using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an unsorted array of string elements
            double[] unsorted = { 1,6,3,7,9,2 };

            // Print the unsorted array
            foreach (var element in unsorted)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();

            // Sort the array
            
            QuickSort.QuickSortArray(unsorted, 0, unsorted.Length - 1);

            // Print the sorted array
            foreach (var element in unsorted)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
