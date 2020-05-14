using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_zadatak
{
    class BankAccountMemento
    {
        public string ownerName { get; private set; }
        public string ownerAddress { get; private set; }
        public decimal balance { get; private set; }

        public BankAccountMemento(string ownerAddress, string ownerName, decimal balance)
        {
            this.ownerAddress = ownerAddress;
            this.ownerName = ownerName;
            this.balance = balance;
        }
    }
}
