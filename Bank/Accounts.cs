using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Checking : BaseAccount
    {
        public Checking(AccountType type, string owner) : base(type, owner) { }
    }

    public class CorpInvest : BaseAccount
    {
        public CorpInvest(AccountType type, string owner) : base(type, owner) { }
    }

    public class IndInvest : BaseAccount
    {
        public IndInvest(AccountType type, string owner) : base(type, owner) { }
        public override void Withdraw(double amt)
        {
            if (amt > 1000.00) throw new BankWithdrawException("Withdrawals limited to $1000 for Individual Investment accounts");
            if (Balance - amt < 0) throw new BankWithdrawException("Overdrafts are not permitted");
            Balance -= amt;
        }
        //public override void Transfer(double amt, BaseAccount to)
        //{
        //    if (amt > 1000.00) throw new BankWithdrawException("Withdrawals limited to $1000 for Individual Investment accounts");
        //    if (Balance - amt < 0) throw new BankWithdrawException("Overdrafts are not permitted");
        //    Balance -= amt;
        //}
    }
}
