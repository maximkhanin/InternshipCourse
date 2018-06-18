using System;
using HW1.PhoneBook;

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

            mobileAccount1.AddContact(mobileAccount2.Number, new SubName("Alex"));

            mobileAccount1.MakeCall(mobileAccount2.Number);
            mobileAccount1.MakeCall(mobileAccount2.Number);
            mobileAccount1.MakeCall(mobileAccount2.Number);

            mobileAccount2.SendMessage(mobileAccount1.Number, "Hello");

            Console.WriteLine("Most Frequently Receiving Numbers");
            mobileOperator.Log.MostFrequentlyReceivingNumbers(5);

            Console.WriteLine("Most Frequently Sendering Numbers");
            mobileOperator.Log.MostFrequentlySendingNumbers(5);

            mobileOperator.PersistJson();
            mobileOperator.RestoreJson();
            
        }
    }
}
