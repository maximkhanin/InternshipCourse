using System.Collections.Generic;
using System.Linq;

namespace HW2
{
    class MobileOperator
    {
        private readonly List<MobileAccount> _mobileAccounts;

        public MobileOperator()
        {
            _mobileAccounts = new List<MobileAccount>();
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

        }

        private void MobileAccount_CallEvent(object sender, int e)
        {
            var receiverMobileAccount = _mobileAccounts.First(i => i.Number == e);
            var senderMobileAccount = (MobileAccount)sender;
            receiverMobileAccount.ReceiveCall(senderMobileAccount.Number);
        }
    }
}
