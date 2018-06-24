using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.GetEncoding(1251);
            Console.OutputEncoding = Encoding.GetEncoding(1251);

            Console.WriteLine("Input the path to the directory");
            var path = Console.ReadLine();

            Console.WriteLine("Input the name of the archive");
            var archiveName = Console.ReadLine();

            if (!Directory.Exists(path))
            {
                return;
            }

            var zip = new Zip();
            zip.MakeZipFile(path, archiveName);
        }
    }
}
