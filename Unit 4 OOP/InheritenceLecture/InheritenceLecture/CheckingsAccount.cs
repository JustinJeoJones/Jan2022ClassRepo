using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceLecture
{
    internal class CheckingsAccount: BankAccount
    {
        public double OverDraftFee { get; set; }

        public CheckingsAccount(int _accountNumber, double _balance, string _customerName, string _customerAddress, double _overDraftFee) : base (_accountNumber, _balance, _customerName, _customerAddress)
        {
            OverDraftFee = _overDraftFee;
        }

        //didn't overridde withdrawl. functionallity was fine
    }
}
