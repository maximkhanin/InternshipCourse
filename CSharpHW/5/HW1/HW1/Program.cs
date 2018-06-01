using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsolePrintFigures();
        }

        private static void ConsolePrintFigures()
        {
            while (true)
            {
                Console.WriteLine("To exit put 'something keyword'" + '\n'
                                  + "Put the number from 1 to 3." + '\n' 
                                  + "1 - Triangle" + '\n' 
                                  + "2 - Square" + '\n' 
                                  + "3 - Romb");

                var resultTypeFigure = int.TryParse(Console.ReadLine(), out var typeFigure);

                if (!resultTypeFigure)
                {
                    break;
                }

                Console.WriteLine("Write the size of figure ");

                var resultSizeFigure = int.TryParse(Console.ReadLine(), out var sizeFigure);

                if (!resultSizeFigure)
                {
                    break;
                }

                switch (typeFigure)
                {
                    case 1:
                        Triangle(sizeFigure);
                        break;
                    case 2:
                        Square(sizeFigure);
                        break;
                    case 3:
                        Romb(sizeFigure);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Data");
                        break;
                }
            }
        }

        private static void Triangle(int k)
        {
            Console.Clear();
            Console.WriteLine("Triangle - {0}", k);

            var result = "";

            for (var i = 0; i < k; i++)
            {
                result += "* ";
                Console.WriteLine(result);
            }
        }

        private static void Square(int k)
        {
            Console.Clear();
            Console.WriteLine("Square - {0}", k);

            var result = "";

            for (var i = 0; i < k; i++)
            {
                result += "* ";
            }

            for (var i = 0; i < k; i++)
            {
                Console.WriteLine(result);
            }
        }

        private static void Romb(int k)
        {
            Console.Clear();
            Console.WriteLine("Romb - {0}", k);

            var x = 2 * k - 1;
            var y = 1;
            while (y < 2 * k)
            {
                for (var i = x; i > 0; i--)
                {
                    Console.Write(" ");
                }
                for (var i = 0; i < y; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                y += 2;
                x -= 2;
            }
            y -= 2;
            x += 2;
            while (y != 1)
            {
                y -= 2;
                x += 2;
                for (var i = x; i > 0; i--)
                {
                    Console.Write(" ");
                }
                for (var i = 0; i < y; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
        }
    }

}
