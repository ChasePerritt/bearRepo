using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Chase Perritt
 * Date: 5 February 2020
 * File: ToyBear.cs
 * Description: This is the file containing the ToyBear interface and one of its associated classes (TeddyBear).
 */
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
            Console.WriteLine("*squeak*");
        }
    }
}
