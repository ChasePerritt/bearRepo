using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bearAdapter
{
    interface Bear
    {
        void maul();
        void hibernate();
    }
    class Grizzly : Bear
    {
        public void maul()
        {
            Console.WriteLine("*rrRARGH*");
        }
        public void hibernate()
        {
            Console.WriteLine("*zzzZzZz*");
        }
    }
}
