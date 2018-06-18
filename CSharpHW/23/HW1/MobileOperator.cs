using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using HW1.Logger;
using HW1.PhoneBook;


namespace HW1
{
    class MobileOperator
    {
        private readonly double _callRate = 1;
        private readonly double _messageRate = 0.5;

        private Dictionary<PhoneNumber, MobileAccount> _mobileAccounts = new Dictionary<PhoneNumber, MobileAccount>();
        public readonly Logger.Logger Log = new Logger.Logger();

        public MobileOperator()
        {
            XmlTextWriter textWritter = new XmlTextWriter("contacts.xml", Encoding.UTF8);
            textWritter.WriteStartDocument();
            textWritter.WriteStartElement("head");
            textWritter.WriteEndElement();
            textWritter.Close();
        }

        private PhoneNumber GenPhoneNumber()
        {
            var rand = new Random(Guid.NewGuid().GetHashCode());
            var phoneNumber = new PhoneNumber(Convert.ToInt64($"{rand.Next(10000, 99999)}{rand.Next(10000, 99999)}"));

            var doc = XDocument.Load("contacts.xml");
            var uniqCheckXElement = doc.Descendants("mobileAccount").
                    FirstOrDefault(x => x.Attribute("number").Value == phoneNumber.Number.ToString());
            
            if (uniqCheckXElement != null)
            {
                GenPhoneNumber();
            }
            return phoneNumber;
        }

        public void AddNumber(MobileAccount mobileAccount)
        {
            if (!Validate(mobileAccount) || _mobileAccounts.ContainsValue(mobileAccount))
            {
                return;
            }
            var phoneNumber = GenPhoneNumber();
            mobileAccount.Number = phoneNumber;

            mobileAccount.CallEvent += MobileAccount_CallEvent;
            mobileAccount.MessageEvent += MobileAccount_MessageEvent;

            var document = new XmlDocument();
            document.Load("contacts.xml");

            var element = document.CreateElement("mobileAccount");
            document.DocumentElement.AppendChild(element);
            var attribute = document.CreateAttribute("number");
            attribute.Value = mobileAccount.Number.ToString();
            element.Attributes.Append(attribute);

            var firstNameElement = document.CreateElement("firstName");
            firstNameElement.InnerText = mobileAccount.FirstName;
            element.AppendChild(firstNameElement);

            var lastNameElement = document.CreateElement("lastName");
            lastNameElement.InnerText = mobileAccount.LastName;
            element.AppendChild(lastNameElement);

            var birthdayElement = document.CreateElement("birthday");
            birthdayElement.InnerText = mobileAccount.Birthday.ToString();
            element.AppendChild(birthdayElement);

            var emailElement = document.CreateElement("email");
            emailElement.InnerText = mobileAccount.Email;
            element.AppendChild(emailElement);

            document.Save("contacts.xml");
            _mobileAccounts.Add(phoneNumber, mobileAccount);
        }

        private void MobileAccount_MessageEvent(object sender, SmsEventArgs smsEventArgs)
        {
            var doc = XDocument.Load("contacts.xml");
            var XElement = doc.Descendants("mobileAccount");
            var uniqCheckXElement = XElement.FirstOrDefault(x => x.Attribute("number").Value == smsEventArgs.Number.Number.ToString()).Attribute("number");
      
            if (uniqCheckXElement != null)
            {
                var mobileAccountReceiver = _mobileAccounts.FirstOrDefault(x => x.Key.Number == long.Parse(uniqCheckXElement.Value));
                var mobileAccountSender = (MobileAccount)sender;
                mobileAccountReceiver.Value.ReceiveMessage(mobileAccountSender.Number, smsEventArgs.Message);
                Log.Add(new Log(mobileAccountSender, mobileAccountReceiver.Value, _messageRate));
            }
        }

        private void MobileAccount_CallEvent(object sender, PhoneNumber phoneNumber)
        {
            var doc = XDocument.Load("contacts.xml");
            var XElement = doc.Descendants("mobileAccount");
            var uniqCheckXElement = XElement.FirstOrDefault(x => x.Attribute("number").Value == phoneNumber.Number.ToString()).Attribute("number");
            Console.WriteLine(uniqCheckXElement);
          
            if (uniqCheckXElement != null)
            {
                var mobileAccountReceiver = _mobileAccounts.FirstOrDefault(x => x.Key.Number == long.Parse(uniqCheckXElement.Value));
                var mobileAccountSender = (MobileAccount) sender;
                mobileAccountReceiver.Value.ReceiveCall(mobileAccountSender.Number);
                Log.Add(new Log(mobileAccountSender, mobileAccountReceiver.Value, _callRate));
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
