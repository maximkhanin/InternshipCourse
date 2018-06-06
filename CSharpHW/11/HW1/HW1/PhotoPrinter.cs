using System;

namespace HW1
{
    public class PhotoPrinter: Printer
    {
        public override void Print(string text)
        {
            Console.WriteLine("Photo Printer - {0}", text);
        }

        public void Print(string text, string photo)
        {
            Console.WriteLine("Photo Printer - {0}, Photo - {1}", text, photo);
        }
    }
}