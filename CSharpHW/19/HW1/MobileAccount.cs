using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class MobileAccount
    {
        public event EventHandler<int> CallEvent;
        public event EventHandler<SmsEventArgs> MessageEvent;
        public int Number { get; }
        public string Name { get; }
        private readonly List<MobileAccount> _contacts;

        public MobileAccount(int number, string name)
        {
            Number = number;
            Name = name;
            _contacts = new List<MobileAccount>();
        }

        public void AddContact(int number, string name)
        {
            if (!_contacts.Exists(e => e.Number == number))
            {
                _contacts.Add(new MobileAccount(number, name));
            }
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
            if (_contacts.Exists(e => e.Number == number))
            {
                var tmp = _contacts.Find(e => e.Number == number);
                Console.WriteLine("Call from {0} to {1}", tmp.Name, Number);
            }
            else
            {
                Console.WriteLine("Call from {0} to {1}", number, Number);
            }
        }


        public void SendMessage(int number, string message)
        {
            if (MessageEvent != null)
            {
                MessageEvent.Invoke(this, new SmsEventArgs { Number = number, Message = message });
            }
        }

        public void ReceiveMessage(int number, string message)
        {
            if (_contacts.Exists(e => e.Number == number))
            {
                var tmp = _contacts.Find(e => e.Number == number);
                Console.WriteLine("Message from {0} to {1}, {2}", tmp.Name, Number, message);
            }
            else
            {    
                Console.WriteLine("Message from {0} to {1}, {2}", number, Number, message);
            }
        }
    }
}
