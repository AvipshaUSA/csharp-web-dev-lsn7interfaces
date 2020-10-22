using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;


            //To sort the availableFlavors list, first create a new FlavorComparer object.
            //FlavorComparer comparer = new FlavorComparer();-------do not need

            //Next, call the Sort method on availableFlavors and pass the comparer object as the argument.

            Console.WriteLine("before:");
            Console.WriteLine("----------\n");

            foreach (var i in availableFlavors) 
            {
               
                Console.WriteLine(i.Name);
            }
            Console.WriteLine("----------\n");

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.

            Console.WriteLine("After:");
            Console.WriteLine("----------\n");

           // availableFlavors.Sort(comparer); ------------do not need


            availableFlavors.Sort(new FlavorComparer());
            foreach (var i in availableFlavors)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine("----------\n");


            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            availableCones.Sort(new ConeComparer());
            foreach (var i in availableCones)
            {
                Console.WriteLine( i.Name+ " : " + i.Cost);
            }
            Console.WriteLine("----------\n");

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
        }
    }
}
