using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using HW1.Logger;
using HW1.PhoneBook;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace HW1
{
    class MobileOperator
    {
        private readonly double _callRate = 1;
        private readonly double _messageRate = 0.5;

        private Dictionary<PhoneNumber, MobileAccount> _mobileAccounts = new Dictionary<PhoneNumber, MobileAccount>();
        public Logger.Logger Log = new Logger.Logger();

        private PhoneNumber GenPhoneNumber()
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

        //JSON Serializer
        public void PersistJson()
        {
            var ticks = DateTime.Now.Ticks;
            var serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (var sw = new StreamWriter(@"accounts.json"))
            using (var writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, _mobileAccounts);
            }
            Console.WriteLine("Performance Test JSON - {0}", DateTime.Now.Ticks - ticks);
        }

        //JSON Serializer
        public void RestoreJson()
        {
            var serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;
            using (var sw = new StreamReader(@"accounts.json"))
            using (JsonReader reader = new JsonTextReader(sw))
            {
                var collDeserialize = (Dictionary<long, MobileAccount>)serializer.Deserialize(reader,
                    typeof(Dictionary<long, MobileAccount>));
                var collAccounts = new Dictionary<PhoneNumber, MobileAccount>();
                foreach (var item in collDeserialize)
                {
                    var key = new PhoneNumber(item.Key);
                    collAccounts.Add(key, item.Value);
                }
                _mobileAccounts = collAccounts;
            }
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
