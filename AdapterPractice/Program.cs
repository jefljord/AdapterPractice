using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Grizzly Frank = new Grizzly();
            TeddyBear Pooky = new TeddyBear();
            BearAdapter x = new BearAdapter(Frank);
            Frank.Maul();
            Frank.Hibernate();
            Pooky.Hug();
            x.Hug();

            Console.ReadLine();
        }
    }
}
