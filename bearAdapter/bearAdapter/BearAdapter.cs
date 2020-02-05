using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bearAdapter
{
    class BearAdapter : ToyBear
    {
        public Bear adaptBear;

        public BearAdapter(Bear b)
        {
            adaptBear = b;
        }
        public void hug()
        {
            return;
        }
    }
}
