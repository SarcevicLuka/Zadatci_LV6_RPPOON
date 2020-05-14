using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Product firstProduct = new Product("Plave muške tenisice", 249.99);
            Product secondProduct = new Product("Crvene ženske tenisice", 299.99);
            Product thirdProduct = new Product("Tenisice za bebe", 149.99);
            Box box = new Box();
            box.AddProduct(firstProduct);
            box.AddProduct(secondProduct);
            box.AddProduct(thirdProduct);

            IAbstractBoxIterator abstractBoxIterator = box.GetBoxIterator();
            BoxIterator boxIterator = (BoxIterator)abstractBoxIterator;

            while (!boxIterator.IsDone)
            {
                Console.WriteLine(boxIterator.Current.ToString());
                boxIterator.Next();
            }
        }
    }
}
