using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the left operand");
            var leftOperandText = Console.ReadLine();
            var leftOperandTest = double.TryParse(leftOperandText, out var leftOperand);
            if (!leftOperandTest)
            {
                Console.WriteLine("Invalid leftOperand");
                return;
            }

            Console.WriteLine("Enter the operation");
            var operation = Console.ReadLine();

            Console.WriteLine("Enter the right operand");

            var rightOperandText = Console.ReadLine();
            var rightOperandTest = double.TryParse(rightOperandText, out var rightOperand);
            if (!rightOperandTest)
            {
                Console.WriteLine("Invalid rightOperand");
                return;
            }

            Console.WriteLine("Result");
            Calculate(leftOperand, rightOperand, operation);
        }
        private static void Calculate(double leftOperand, double rightOperand, string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine(Math.Round(leftOperand + rightOperand, 2));
                    break;
                case "-":
                    Console.WriteLine(Math.Round(leftOperand - rightOperand, 2));
                    break;
                case "*":
                    Console.WriteLine(Math.Round(leftOperand * rightOperand, 2));
                    break;
                case "/":
                    Console.WriteLine(Math.Round(leftOperand / rightOperand, 2));
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
    }
}
