namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobileOperator = new MobileOperator();

            var mobileAccount1 = new MobileAccount(123);
            var mobileAccount2 = new MobileAccount(456);
           
            mobileOperator.AddNumber(mobileAccount1);
            mobileOperator.AddNumber(mobileAccount2);

            mobileAccount1.MakeCall(456);
            mobileAccount2.SendMessage(123, "Hello");
        }
    }
}
