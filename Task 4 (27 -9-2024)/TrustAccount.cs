using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class TrustAccount : SavingsAccount
    {
        int NumOfWithdrawPerYear;
        public TrustAccount(string name = "Unnamed Account", double balance = 0.0, double intRate = 0.0) :base(name,balance,intRate)
        {
            NumOfWithdrawPerYear = 0;
        }
        public  bool Deposit(double amount)
        {
            bool flag = false;
            if(amount >= 5000)
            {
                flag = base.Deposit(amount + 50);
            }
            else
            {
                flag = base.Deposit(amount );
            }
            return flag;
        }
        public  bool Withdraw(double amount)
        {
            bool flag = false;
            DateTime CurrentTime = new DateTime();
            DateTime timeAfterYear = new DateTime();

            if(NumOfWithdrawPerYear == 0)
            {
                CurrentTime = DateTime.Now;
                timeAfterYear = CurrentTime.AddYears(1);
            }
            if(DateTime.Now > timeAfterYear)
            {
                NumOfWithdrawPerYear = 0;
            }
            if (NumOfWithdrawPerYear < 3)
            {
                if ((amount) < (.2 * Balance))
                {
                    NumOfWithdrawPerYear++;
                    return base.Withdraw(amount);
                }
            }
            return flag;
        }
    }
}
