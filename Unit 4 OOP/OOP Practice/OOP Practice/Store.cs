using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    internal class Store
    {
        public int supply { get; set; }
        public List<Customer> customers { get; set; }
        public Store(int _supply, List<Customer> _customers)
        {
            supply = _supply;
            customers = _customers;
        }

        public bool runStore()
        {
            int demand = 0;
            foreach(Customer c in customers)
            {
                demand += c.amount;
            }

            if(demand <= supply)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
