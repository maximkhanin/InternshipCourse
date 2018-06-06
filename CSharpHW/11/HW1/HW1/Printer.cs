using System;

namespace HW1
{
    public class Printer
    {
        public virtual void Print(string text)
        {
            Console.WriteLine("Printer - {0}", text);
        }
    }
}