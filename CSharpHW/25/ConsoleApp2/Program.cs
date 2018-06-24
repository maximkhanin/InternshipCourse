using System;
using System.IO;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.GetEncoding(1251);
            Console.OutputEncoding = Encoding.GetEncoding(1251);

            Console.WriteLine("Input the path to the directory");
            var path = Console.ReadLine();
           
            if (!Directory.Exists(path))
            {
                return;
            }
            
            var zipUnpack = new ZipUnpack();
            zipUnpack.ExtractAllZip(path);
        }
    }
}
