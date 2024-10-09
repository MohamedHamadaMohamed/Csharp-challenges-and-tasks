using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(string name = "Unnamed Account", double balance = 0.0) : base(name, balance)
        { 
        
        }
        public bool Withdraw(double amount)
        {
            return base.Withdraw(amount + 1.5);
        }
    }
}
