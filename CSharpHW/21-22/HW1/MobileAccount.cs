using System;
using HW1.PhoneBook;

namespace HW1
{
    [Validation.MobileAccountValidation]
    class MobileAccount
    {
        public event EventHandler<PhoneNumber> CallEvent;
        public event EventHandler<SmsEventArgs> MessageEvent;

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        
        private readonly Book _phoneBook;

        public PhoneNumber Number { get; set; }

        public MobileAccount(string firstName, string lastName, DateTime birthday, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            Email = email;
            _phoneBook = new Book();
         }
       
        public void AddContact(PhoneNumber phoneNumber, SubName subName)
        {
            if (!_phoneBook.ContainsKey(phoneNumber))
            {
                _phoneBook.Add(phoneNumber, subName);
            }
        }

        public void MakeCall(PhoneNumber phoneNumber)
        {
            CallEvent?.Invoke(this, phoneNumber);
        }

        public void ReceiveCall(PhoneNumber phoneNumber)
        {
            if (_phoneBook.ContainsKey(phoneNumber))
            {
                Console.WriteLine("Call from {0} to {1}", _phoneBook[phoneNumber], Number);
            }
            else
            {
                Console.WriteLine("Call from {0} to {1}", phoneNumber, Number);
            }
        }

        public void SendMessage(PhoneNumber phoneNumber, string message)
        {
            MessageEvent?.Invoke(this, new SmsEventArgs { Number = phoneNumber, Message = message });
        }

        public void ReceiveMessage(PhoneNumber phoneNumber, string message)
        {
            if (_phoneBook.ContainsKey(phoneNumber))
            {
                Console.WriteLine("Message from {0} to {1}, {2}", _phoneBook[phoneNumber], Number, message);
            }
            else
            {
                Console.WriteLine("Message from {0} to {1}, {2}", phoneNumber, Number, message);
            }   
        }

        
    }
}
