using System;

namespace HW1
{
    class Program
    {
        private const string Name = "Maxim";

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}", Name);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
