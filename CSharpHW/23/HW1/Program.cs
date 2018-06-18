using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobileOperator = new MobileOperator();
      
            var mobileAccount1 = new MobileAccount("Max", "Kh", new DateTime(1998, 6, 23), "test@mail.com");
            var mobileAccount2 = new MobileAccount("Alex", "Kh", new DateTime(1992, 11, 27), "test1@mail.com");

            mobileOperator.AddNumber(mobileAccount1);
            mobileOperator.AddNumber(mobileAccount2);

            Console.WriteLine(mobileAccount1.Number);
            Console.WriteLine(mobileAccount2.Number);

            mobileAccount1.MakeCall(mobileAccount2.Number);

            mobileAccount2.MakeCall(mobileAccount1.Number);

            mobileAccount1.SendMessage(mobileAccount2.Number,"Message text");

            mobileOperator.Log.MostFrequentlyReceivingNumbers(5);
        }
    }
}
