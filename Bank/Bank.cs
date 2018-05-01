using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank
    {
        public string BankName { get; }
        public List<BaseAccount> AccountList { get; set; }

        public Bank(string name)
        {
            BankName = name;
            AccountList = new List<BaseAccount>();
        }
        public void AddAcount(AccountType type, string owner)
        {
            switch (type)
            {
                case AccountType.Checking:
                    AccountList.Add(new Checking(AccountType.Checking, owner));
                    break;
                case AccountType.CorporateInvestment:
                    AccountList.Add(new CorpInvest(AccountType.CorporateInvestment, owner));
                    break;
                case AccountType.IndividualInvestment:
                    AccountList.Add(new IndInvest(AccountType.IndividualInvestment, owner));
                    break;
                default:
                    break;
            }
        }

        public BaseAccount FindAccount(AccountType type, string owner)
        {
            BaseAccount retval = null;
            foreach (BaseAccount acct in AccountList)
                if (acct.AccType == type && acct.OwnerName == owner) {
                    retval = acct;
                    break;
                }
            if (retval == null) throw new BankAccountNotFound();
            return retval;
        }
        public string ListAccounts()
        {
            StringBuilder sb = new StringBuilder();
            double totalLiablities = 0.0;
            sb.AppendFormat("Accounts for {0}\n", BankName);
            sb.AppendLine("");
            foreach (BaseAccount acct in AccountList)
            {
                sb.AppendFormat("Account Owner: {0}  Account Type: {1}  Account Balance: {2}\n", acct.OwnerName, acct.AccType, acct.Balance);
                totalLiablities += acct.Balance;
            }
            sb.AppendFormat("\nTotal liabilities: {0}", totalLiablities);

            return sb.ToString();
        }
    }

    public enum AccountType
    {
        Checking,
        CorporateInvestment,
        IndividualInvestment
    }
}
