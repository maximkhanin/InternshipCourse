using System;

namespace HW1
{
    public class ColourPrinter: Printer
    {
        public override void Print(string text)
        {
            Console.WriteLine("Colour Printer - {0}", text);
        }

        public void Print(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("Colour Printer - {0}", text);
        }
    }
}