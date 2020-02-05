using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Chase Perritt
 * Date: 5 February 2020
 * File: Program.cs
 * Description: This is the main driver file for the bearAdapter program.
 */
namespace bearAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear aBear = new Grizzly();
            ToyBear aToyBear = new TeddyBear();
            ToyBear adaptToy = new BearAdapter(aBear); // Creates a ToyBear from a Bear

            // Testing Bear functionality
            Console.Write("Grizzly Mauling: ");
            aBear.maul();
            Console.WriteLine();
            Console.Write("Grizzly Hibernation: ");
            aBear.hibernate();
            Console.WriteLine();

            // Testing ToyBear functionality
            Console.Write("Teddy Bear Hug: ");
            aToyBear.hug();
            Console.WriteLine();

            // Testing BearAdapter functionality
            Console.Write("Toy-Grizzly Hug: ");
            adaptToy.hug();

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
