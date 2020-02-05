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
            return;
        }
        public void hibernate()
        {
            return;
        }
    }
}
