namespace Task_4
{
    public class Account
    {
        public string Name { set; get; }
        public double Balance { set; get; }

        public Account(string name = "Unnamed Account", double balance = 0.0)
        {
            this.Name = name;
            this.Balance = balance;
        }

        public bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                Balance += amount;
                return true;
            }
        }

        public virtual bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetBalance()
        {
            return Balance;
        }
        public static Account operator +(Account left ,Account right)
        {
           Account result = new Account(left.Name,left.Balance+right.Balance);
           return result;
        }
    }
    
}
