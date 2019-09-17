using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPractice
{
    class TeddyBear : ToyBear
    {
        public void Hug()
        {
            Console.WriteLine("Pooky uses Hug.\nRage effect is nullified");
        }
    }
}
