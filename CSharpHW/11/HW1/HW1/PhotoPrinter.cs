using System;
using System.Drawing;

namespace HW1
{
    public class PhotoPrinter: Printer
    {
        public override void Print(string text)
        {
            Console.WriteLine("Photo Printer - {0}", text);
        }

        public void Print(Image photo)
        {
            Console.WriteLine("Photo Printer - {0}", photo);
        }
    }
}