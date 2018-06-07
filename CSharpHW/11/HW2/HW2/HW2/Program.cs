using System;
using System.Collections.Generic;
using System.Drawing;
using HW1;

namespace HW2
{
    static class Program
    {
        static void Main(string[] args)
        {
            var colourPrinterParam1 = new ColourPrinterParams
            {
                Color = ConsoleColor.Blue,
                Text = "Test1"
            };
            var colourPrinterParam2 = new ColourPrinterParams
            {
                Color = ConsoleColor.DarkRed,
                Text = "Test2"
            };

            var colourPrinterParams = new List<ColourPrinterParams>
            {
                colourPrinterParam1,
                colourPrinterParam2
            };

            colourPrinterParams.Print();

        }

        public static void Print(this string[] prArray)
        {
            foreach (var pr in prArray)
            {
                Console.WriteLine("{0}; ", pr);
            }
        }

        public class ColourPrinterParams
        {
            public string Text { get; set; }
            public ConsoleColor Color { get; set; }
        }

        public class PhotoPrinterParams
        {
            public Image Image { get; set; }
        }

        public class PrinterParams
        {
            public string Text { get; set; }
        }

        public static void Print(this List<PhotoPrinterParams> photoPrinterParams)
        {
            var photoPrinter = new PhotoPrinter();
            foreach (var photoPrinterParam in photoPrinterParams)
            {
                photoPrinter.Print(photoPrinterParam.Image);
            }
        }

        public static void Print(this List<ColourPrinterParams> colourPrinterParams)
        {
            var coloutPrinter = new ColourPrinter();
            foreach (var colourPrinterParam in colourPrinterParams)
            {
                coloutPrinter.Print(colourPrinterParam.Text, colourPrinterParam.Color);
            }
        }

        public static void Print(this List<PrinterParams> printerParams)
        {
            var printer = new Printer();
            foreach (var printerParam in printerParams)
            {
                printer.Print(printerParam.Text);
            }
        }
    }
}
