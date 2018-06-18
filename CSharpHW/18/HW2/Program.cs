namespace HW2
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
            mobileAccount2.SendMessage(123, "Hello");
        }
    }
}
