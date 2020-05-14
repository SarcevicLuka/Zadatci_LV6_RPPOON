using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_zadatak
{
    class CareTaker
    {
        private int toBeRestored;
        private List<Memento> PreviousStates;

        public CareTaker()
        {
            this.PreviousStates = new List<Memento>();
            this.toBeRestored = 0;
        }
        public CareTaker(List<Memento> previousStates)
        {
            this.PreviousStates = previousStates;
            this.toBeRestored = previousStates.Count;
        }
        public Memento RestorePreviousState()
        {
            Console.WriteLine("Broj mementa:" + this.toBeRestored);
            if (this.toBeRestored-1 < 0)
            {
                Console.WriteLine("Out of bounds!");
            }
            return PreviousStates[--this.toBeRestored];
        }
        public void AddState(Memento previousState)
        {
            this.toBeRestored++;
            this.PreviousStates.Add(previousState);
        }
        public void RemovePreviousState()
        {
            if (this.toBeRestored < 0 || this.toBeRestored > this.PreviousStates.Count - 1)
            {
                Console.WriteLine("Out of bounds!");
            }
            else
            {
                PreviousStates.RemoveAt(toBeRestored);
                toBeRestored--;
            }
        }
    }
}
