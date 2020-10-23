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



            Console.WriteLine("\n\n\t--------------------\n");
            Console.WriteLine("\tname of all Allergens:"); // for my understanding I print all allergens
            Console.WriteLine("\t---------------------\n");

            foreach (var i in availableFlavors)
            {
                foreach (var m in i.Allergens)
                {
                    Console.WriteLine("\t"+m);
                }
            }
            

            //To sort the availableFlavors list, first create a new FlavorComparer object.
            //FlavorComparer comparer = new FlavorComparer();-------do not need

            //Next, call the Sort method on availableFlavors and pass the comparer object as the argument.
            Console.WriteLine("\t---------------------\n");
            Console.WriteLine("\tFlavor Before Sorting:");
            Console.WriteLine("\t---------------------\n\n");

            foreach (var i in availableFlavors) 
            {
               
                Console.WriteLine("\t"  +i.Name);
            }
            

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            Console.WriteLine("\t---------------------\n");
            Console.WriteLine("\tFlavour After sorting:");
            Console.WriteLine("\t---------------------\n\n");

            // availableFlavors.Sort(comparer); ------------do not need


            //availableFlavors.Sort(new FlavorComparer());// compare by name alphabetically
            //foreach (var i in availableFlavors)
            //{


            //    Console.WriteLine(i.Name);
            //}
            //Console.WriteLine("----------\n");


            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            Console.WriteLine("\t---------------------\n");
            Console.WriteLine("\tCone Befor sorting by Cost:");
            Console.WriteLine("\t---------------------\n\n");
            foreach (var i in availableCones)
            {
                Console.WriteLine("\t"+i.Name + " : " + i.Cost);
            }
           



            Console.WriteLine("\t------------------------\n");
            Console.WriteLine("\tCone After sorting by Cost:");
            Console.WriteLine("\t-----------------------\n\n");
            availableCones.Sort(new ConeComparer());
            foreach (var i in availableCones)
            {
                Console.WriteLine( "\t"+i.Name+ " : " + i.Cost);
            }
        

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.

            //Modify FlavorComparer to sort Flavor objects by the number of allergens, from lowest to highes
            Console.WriteLine("\t---------------------------\n");
            Console.WriteLine("\tFlavour After sorting by allergens Count:");
            Console.WriteLine("\t-----------------------------\n\n");

            availableFlavors.Sort(new FlavorComparer());
            foreach (var i in availableFlavors)
            {


                Console.WriteLine($"        {i.Name} = {i.Allergens.Count} count\n\n");
            }
            

        }
    }
}
