using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Note firstNote = new Note("Zadaća", "Napiši zadaću do ponedjeljka.");
            Note secondNote = new Note("Ispit", "Imaš ispit 25.6.2020.");
            Note thirdNote = new Note("Vježbanje", "Vježbaj u 18 sati.");
            Notebook notebook = new Notebook();
            notebook.AddNote(firstNote);
            notebook.AddNote(secondNote);
            notebook.AddNote(thirdNote);

            IAbstractIterator abstractIterator = notebook.GetIterator();
            Iterator iterator = (Iterator)abstractIterator;

            while (!iterator.IsDone)
            {
                iterator.Current.Show();
                iterator.Next();
            }
        }
    }
}
