using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPractice
{
    class Grizzly : Bear
    {
        public void Maul()
        {
            Console.WriteLine("The bear uses swipe!\nIt's super effective!");
        }
        public void Hibernate()
        {
            Console.WriteLine("Bear uses Hibernate. Bear recovers");
        }
    }
}
