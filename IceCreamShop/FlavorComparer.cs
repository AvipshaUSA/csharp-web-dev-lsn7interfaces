using System;
using System.Collections.Generic;
using System.Text;


namespace IceCreamShop
{
    class FlavorComparer: IComparer<Flavor>
    {

        //--------------------- to compare name alphabetically---------------------


        //public Flavor(string name, double cost, List<string> allergens) : base(name, cost, allergens)
        //public int Compare(Flavor x, Flavor y)

        //{
            
            
        //    return string.Compare(x.Name, y.Name);
            
        //}


        //-------------------compair flavour according to number of count----------------------

        public int Compare(Flavor x, Flavor y)

        {

            if (x.Allergens.Count < 0)
            {
                return -1;

            }else if (x.Allergens.Count> 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        
    }
}
