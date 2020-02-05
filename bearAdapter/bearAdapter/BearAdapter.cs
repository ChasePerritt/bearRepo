using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Chase Perritt
 * Date: 5 February 2020
 * File: BearAdapter.cs
 * Description: This is the file containing the BearAdapter, a class under the ToyBear interface
 *              that passes a call from ToyBear's hug() to the Bear interface's maul().
 */
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
            adaptBear.maul();
        }
    }
}
