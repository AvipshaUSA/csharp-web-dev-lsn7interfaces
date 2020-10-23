using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    public class Flavor : Ingredient
    {
        internal static readonly object Ingradient;

        public Flavor(string name, double cost, List<string> allergens) : base(name, cost, allergens)
        {
            Name = name;
            Cost = cost;
            Allergens = allergens;

        }
    }
}
