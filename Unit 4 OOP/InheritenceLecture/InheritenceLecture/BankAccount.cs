using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceLecture
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }

        public BankAccount(int _accountNumber, double _balance, string _customerName, string _customerAddress)
        {
            AccountNumber = _accountNumber;
            Balance = _balance;
            CustomerName = _customerName;
            CustomerAddress = _customerAddress;
        }

        public void Deposit(double money)
        {
            Balance += money;
        }

        public virtual void Withdraw(double money)
        {
            Balance -= money;
        }
    }
}
