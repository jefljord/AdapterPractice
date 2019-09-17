using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPractice
{
    class BearAdapter 
    {
        Bear Kody;
        public BearAdapter(Bear a)
        {
            Kody = a;
        }
        public void Hug()
        {
            Kody.Maul();
            Kody.Hibernate();
        }
    }
}
