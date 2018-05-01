using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankWithdrawException : Exception
    {
        public BankWithdrawException() { }

        public BankWithdrawException(string message) : base(message) { }

        public BankWithdrawException(string message, Exception inner) : base(message, inner) { }
    }
}
