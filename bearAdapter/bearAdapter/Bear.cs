using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Chase Perritt
 * Date: 5 February 2020
 * File: Bear.cs
 * Description: This is the file containing the Bear interface and all associated classes with their implementations.
 */
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
