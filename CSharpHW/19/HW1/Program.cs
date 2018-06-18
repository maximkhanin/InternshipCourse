using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobileOperator = new MobileOperator();

            var mobileAccount1 = new MobileAccount(123,"Alex");
            var mobileAccount2 = new MobileAccount(456,"Max");

            mobileOperator.AddNumber(mobileAccount1);
            mobileOperator.AddNumber(mobileAccount2);
            mobileAccount1.AddContact(456, "Max");

            mobileAccount2.MakeCall(123);
            mobileAccount2.MakeCall(123);
            mobileAccount2.MakeCall(123);
            mobileAccount2.MakeCall(123);
            mobileAccount1.MakeCall(456);
            mobileAccount1.MakeCall(456);
            mobileAccount1.MakeCall(456);

            mobileAccount2.SendMessage(123, "Hello");


            Console.WriteLine("Most Frequently Receiving Numbers");
            mobileOperator.MostFrequentlyReceivingNumbers(5);

            Console.WriteLine("Most Frequently Sendering Numbers");
            mobileOperator.MostFrequentlySendingNumbers(5);
        }
    }
}
