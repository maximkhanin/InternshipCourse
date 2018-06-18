using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using HW1.Logger;
using HW1.PhoneBook;

namespace HW1
{
    class MobileOperator
    {
        private readonly double _callRate = 1;
        private readonly double _messageRate = 0.5;
       
        private readonly Dictionary<PhoneNumber, MobileAccount> _mobileAccounts;
        public Logger.Logger Log { get; }

        public MobileOperator()
        {
            _mobileAccounts = new Dictionary<PhoneNumber, MobileAccount>();
            Log = new Logger.Logger();
        }

        public PhoneNumber GenPhoneNumber()
        {
            var rand = new Random(Guid.NewGuid().GetHashCode());
            return new PhoneNumber(Convert.ToInt64($"{rand.Next(10000, 99999)}{rand.Next(10000, 99999)}"));
        }

        public void AddNumber(MobileAccount mobileAccount)
        {
            if (!Validate(mobileAccount))
            {
                return;
            }
            var phoneNumber = GenPhoneNumber();
            while (_mobileAccounts.ContainsKey(phoneNumber))
            {
                phoneNumber = GenPhoneNumber();
            }
            mobileAccount.Number = phoneNumber;
            _mobileAccounts.Add(phoneNumber, mobileAccount);
            mobileAccount.CallEvent += MobileAccount_CallEvent;
            mobileAccount.MessageEvent += MobileAccount_MessageEvent;
        }

        private void MobileAccount_MessageEvent(object sender, SmsEventArgs smsEventArgs)
        {
            var receiverMobileAccount = _mobileAccounts.First(i => i.Value.Number == smsEventArgs.Number);
            var senderMobileAccount = (MobileAccount)sender;
            receiverMobileAccount.Value.ReceiveMessage(senderMobileAccount.Number, smsEventArgs.Message);
            Log.Add(new Log(senderMobileAccount, receiverMobileAccount.Value, _messageRate));
        }

        private void MobileAccount_CallEvent(object sender, PhoneNumber phoneNumber)
        {
            var receiverMobileAccount = _mobileAccounts.First(i => i.Key == phoneNumber);
            var senderMobileAccount = (MobileAccount)sender;
            receiverMobileAccount.Value.ReceiveCall(senderMobileAccount.Number);
            Log.Add(new Log(senderMobileAccount, receiverMobileAccount.Value, _callRate));
        }

        private bool Validate(MobileAccount mobileAccount)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(mobileAccount);
            if (!Validator.TryValidateObject(mobileAccount, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }

                return false;
            }

            Console.WriteLine("User '{0} {1}' is Valid", mobileAccount.FirstName, mobileAccount.LastName);
            return true;
        }
    }
}
