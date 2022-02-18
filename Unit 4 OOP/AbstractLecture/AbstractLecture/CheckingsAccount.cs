using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLecture
{
    internal class CheckingsAccount : BankAccount
    {
        public double OverDraft { get; set; }
        public CheckingsAccount(double _balance, string _name, double _overdraft)
        {
            Balance = _balance;
            CustomerName = _name;
            OverDraft = _overdraft;
        }

        public override void Withdraw(double money)
        {
            Balance -= money;
            if(Balance < 0)
            {
                Balance -= OverDraft;
            }
        }
    }
}
