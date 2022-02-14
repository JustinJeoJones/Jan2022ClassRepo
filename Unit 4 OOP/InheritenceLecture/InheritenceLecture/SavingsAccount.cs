using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceLecture
{
    internal class SavingsAccount: BankAccount
    {
        public double InterestRate { get; set; }
        //child constructor
        public SavingsAccount(int _accountNumber, double _balance, string _customerName, string _customerAddress,double _interestRate) : base(_accountNumber, _balance, _customerName, _customerAddress)
        {
            InterestRate = _interestRate;
        }

        //override
        public override void Withdraw(double money)
        {
            //We don't want original withdrawl method
            //base.Withdraw(money);
            if(money > Balance)
            {
                Console.WriteLine("You do not have enough money in your savings account.");
            }
            else
            {
                Balance -= money;
            }
        }

    }
}
