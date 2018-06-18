namespace HW1
{
    class Log
    {
        public MobileAccount Sender { get; }
        public  MobileAccount Receiver { get; }
        public double Rate { get; }
        public Log(MobileAccount sender, MobileAccount receiver, double rate)
        {
            Sender = sender;
            Receiver = receiver;
            Rate = rate;
        }
    }
}
