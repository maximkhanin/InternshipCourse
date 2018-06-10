using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Numbers();
            var lottery = new Lottery();

            var lotteryTicket = lottery.GetNumber();

            for (var i = 0; i < lotteryTicket.Length; i++)
            {
                Console.Write(lotteryTicket[i].Value);
            }

            Console.WriteLine();
            Console.WriteLine(lottery.WinCheck(numbers.GetNumber()) ? "You win" : "You lose");
        }
    }
}
