using System;
using System.Collections.Generic;
using System.Linq;

namespace HW1
{
    class MobileOperator
    {
        private readonly double _callRate = 1;
        private readonly double _messageRate = 0.5;
        
        private readonly List<MobileAccount> _mobileAccounts;
        private readonly List<Log> _log;

        public MobileOperator()
        {
            _mobileAccounts = new List<MobileAccount>();
            _log = new List<Log>();
           
        }

        public void AddNumber(MobileAccount mobileAccount)
        {
            _mobileAccounts.Add(mobileAccount);
            mobileAccount.CallEvent += MobileAccount_CallEvent;
            mobileAccount.MessageEvent += MobileAccount_MessageEvent;
        }

        private void MobileAccount_MessageEvent(object sender, SmsEventArgs e)
        {
            var receiverMobileAccount = _mobileAccounts.First(i => i.Number == e.Number);
            var senderMobileAccount = (MobileAccount)sender;
            receiverMobileAccount.ReceiveMessage(senderMobileAccount.Number, e.Message);
            _log.Add(new Log(senderMobileAccount, receiverMobileAccount, _messageRate));
        }

        private void MobileAccount_CallEvent(object sender, int e)
        {
            var receiverMobileAccount = _mobileAccounts.First(i => i.Number == e);
            var senderMobileAccount = (MobileAccount)sender;
            receiverMobileAccount.ReceiveCall(senderMobileAccount.Number);
            _log.Add(new Log(senderMobileAccount, receiverMobileAccount, _callRate));
        }

        public void MostFrequentlyReceivingNumbers(int count)
        {
            var result = _log.GroupBy(x => x.Receiver).OrderByDescending(x => x.Count()).Take(count);

            foreach (var item in result)
            { 
                var tmp = 0.0;

                foreach (var t in item)
                {
                    tmp += t.Rate;
                }

                Console.WriteLine("{0} - {1}", item.Key.Number,tmp); 
            }
        }

        public void MostFrequentlySendingNumbers(int count)
        {
            var result = _log.GroupBy(x => x.Sender).OrderByDescending(x => x.Count()).Take(count);
            foreach (var item in result)
            {
                var tmp = 0.0;

                foreach (var t in item)
                {
                    tmp += t.Rate;
                }

                Console.WriteLine("{0} - {1}", item.Key.Number, tmp);
            }
        }
    }
}
