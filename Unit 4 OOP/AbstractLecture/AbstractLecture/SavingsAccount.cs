using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLecture
{
    internal class SavingsAccount : BankAccount
    {
        public SavingsAccount(double _balance, string _name)
        {
            Balance = _balance;
            CustomerName = _name;
        }
        public override void Withdraw(double money)
        {
            if(money > Balance)
            {
                Console.WriteLine("You are broke LOL");
            }
            else
            {
                Balance -= money;
            }
        }
    }
}
