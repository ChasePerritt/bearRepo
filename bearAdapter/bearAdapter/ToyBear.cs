using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bearAdapter
{
    interface ToyBear
    {
        void hug();
    }
    class TeddyBear : ToyBear
    {
        public void hug()
        {
            return;
        }
    }
}
