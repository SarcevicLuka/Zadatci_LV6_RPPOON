using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoItem ToDoItem = new ToDoItem("Zadaća","Napravi zadaću", DateTime.Now);

            CareTaker careTaker = new CareTaker();
            careTaker.AddState(ToDoItem.StoreState());
            ToDoItem.ChangeTask("Prati nastavu iz engleskog!");
            ToDoItem.Rename("Nastava");
            careTaker.AddState(ToDoItem.StoreState());
            //Restore zadnji memento
            ToDoItem.RestoreState(careTaker.RestorePreviousState());
            Console.WriteLine(ToDoItem.ToString());
            //Restore predzadnji memento
            ToDoItem.RestoreState(careTaker.RestorePreviousState());
            Console.WriteLine(ToDoItem.ToString());
            //Pokušati izaći izvan granica
            ToDoItem.RestoreState(careTaker.RestorePreviousState());
            Console.WriteLine(ToDoItem.ToString());
        }
    }
}
