using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bearAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear aBear = new Grizzly();
            ToyBear aToyBear = new TeddyBear();
            ToyBear adaptToy = new BearAdapter(aBear);

            Console.Write("Grizzly Mauling: ");
            aBear.maul();
            Console.WriteLine();
            Console.Write("Grizzly Hibernation: ");
            aBear.hibernate();
            Console.WriteLine();

            Console.Write("Teddy Bear Hug: ");
            aToyBear.hug();
            Console.WriteLine();

            Console.Write("Toy-Grizzly Hug: ");
            adaptToy.hug();

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
