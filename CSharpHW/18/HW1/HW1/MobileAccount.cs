using System;

namespace HW1
{
    class MobileAccount
    {
        public event EventHandler<int> CallEvent;
        public event EventHandler<SmsEventArgs> MessageEvent;

        public int Number { get; }

        public MobileAccount(int number)
        {
            Number = number;
        } 

        public void MakeCall(int number)
        {
            if (CallEvent != null)
            {
                CallEvent.Invoke(this, number);
            }
        }

        public void ReceiveCall(int number)
        {
            Console.WriteLine("Call from {0} to {1}", number, Number);
        }

        public void SendMessage(int number, string message)
        {
            if (MessageEvent != null)
            {
                MessageEvent.Invoke(this, new SmsEventArgs { Number = number, Message = message});
            }
        }

        public void ReceiveMessage(int number, string message)
        {
            Console.WriteLine("Message from {0} to {1}, {2}", number, Number, message);
        }
    }
}
