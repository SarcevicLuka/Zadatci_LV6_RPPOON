using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zadatak
{
    interface IAbstractBoxCollection
    {
        IAbstractBoxIterator GetBoxIterator();
    }
}
