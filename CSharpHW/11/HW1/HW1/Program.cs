using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            printer.Print("Test1");

            var photoPrinter = new PhotoPrinter();
            photoPrinter.Print("Test2");
            photoPrinter.Print("Test2","img2");

            var colourPrinter= new ColourPrinter();
            colourPrinter.Print("test3");
            colourPrinter.Print("test3",ConsoleColor.Cyan);
        }
    }
}