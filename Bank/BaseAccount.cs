using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class BaseAccount
    {
        public string OwnerName { get; set; }
        public AccountType AccType { get; set; }
        public double Balance { get; set; }

        public BaseAccount(AccountType type, string owner)
        {
            AccType = type;
            OwnerName = owner;
            Balance = 0;
        }

        public void Deposit(double amt)
        {
            Balance += amt;
        }
        public virtual void Withdraw(double amt)
        {
            if (Balance - amt < 0) throw new BankWithdrawException("Overdrafts are not permitted");
            Balance -= amt;
        }
       
        public virtual void Transfer(double amt, BaseAccount to)
        {
            this.Withdraw(amt);
            to.Deposit(amt);
        }
        
    }

}
