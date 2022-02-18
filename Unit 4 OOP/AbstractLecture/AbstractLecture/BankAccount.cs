using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLecture
{
    internal abstract class BankAccount
    {
        public double Balance { get; set; }
        public string CustomerName { get; set; }

        public abstract void Withdraw(double money);

        public void Deposit(double money)
        {
            Balance += money;
        }
    }
}
