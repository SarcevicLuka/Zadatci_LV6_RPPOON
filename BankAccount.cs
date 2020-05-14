using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_zadatak
{
    class BankAccount
    {
        private string ownerName;
        private string ownerAddress;
        private decimal balance;
        public BankAccount(string ownerAddress, string ownerName, decimal balance)
        {
            this.ownerName = ownerName;
            this.ownerAddress = ownerAddress;
            this.balance = balance;
        }
        public void ChangeOwnerAddress(string address)
        {
            this.ownerAddress = address;
        }
        public void UpdateBalance(decimal amount) { this.balance += amount; }
        public string OwnerName { get { return this.ownerName; } }
        public string OwnerAddress { get { return this.ownerAddress; } }
        public decimal Balance { get { return this.balance; } }
        public override string ToString()
        {
            return  " Owner address: " + this.ownerAddress + " Owner name: " + this.ownerName + " Balance: " + this.balance;
        }
        public BankAccountMemento StoreState()
        {
            return new BankAccountMemento(this.ownerAddress, this.ownerName, this.balance);
        }
        public void RestoreState(BankAccountMemento previous)
        {
            this.ownerAddress = previous.ownerAddress;
            this.ownerName = previous.ownerName;
            this.balance = previous.balance;
        }
    }
}
