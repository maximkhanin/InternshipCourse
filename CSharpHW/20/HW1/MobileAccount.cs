using System;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;
using HW1.PhoneBook;

namespace HW1
{
    [Validation.MobileAccountValidation]
    class MobileAccount
    { 
        public event EventHandler<PhoneNumber> CallEvent;
        public event EventHandler<SmsEventArgs> MessageEvent;

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        public MailAddress Email { get; set; }

        private readonly Book _phoneBook;

        public PhoneNumber Number { get; set; }

        public MobileAccount(string firstName, string lastName, DateTime birthday, MailAddress email)
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
            if (CallEvent != null)
            {
                CallEvent.Invoke(this, phoneNumber);
            }
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
            if (MessageEvent != null)
            {
                MessageEvent.Invoke(this, new SmsEventArgs { Number = phoneNumber, Message = message });
            }
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
