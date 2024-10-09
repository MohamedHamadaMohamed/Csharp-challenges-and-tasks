using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class SavingsAccount : Account
    {
        public double IntRate { set; get; }
        public SavingsAccount(string name = "Unnamed Account", double balance = 0.0, double intRate= 0.0) : base(name, balance)
        {
            IntRate = intRate;
        }
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount+IntRate);
        }

    }
}
