using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("Aleja kestenova 63", "Luka Šarčević", 1000);
            Console.WriteLine(bankAccount.ToString());
            BankAccountMemento memento = bankAccount.StoreState();
            bankAccount.UpdateBalance(1500);
            bankAccount.ChangeOwnerAddress("Frankopanska 6");
            Console.WriteLine(bankAccount.ToString());
            bankAccount.RestoreState(memento);
            Console.WriteLine(bankAccount.ToString());
        }
    }
}
