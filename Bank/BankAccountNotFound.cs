using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankAccountNotFound : Exception
    {
        public BankAccountNotFound() { }

        public BankAccountNotFound(string message) : base(message) { }

        public BankAccountNotFound(string message, Exception inner) : base(message, inner) { }
    }
}
