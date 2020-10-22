using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace IceCreamShop
{
    class ConeComparer : IComparer <Cone>
    {

        public int Compare(Cone x, Cone y)
        {
           // double z = x.Cost - y.Cost;

            //if (z < 0)
            //{
            //    return -1;
            //}
            if (x.Cost > y.Cost)
            {
                return 1;
            }else if(x.Cost < y.Cost) { 

                    return -1;
            }
            else
            {
                return 0;
            }
        }

    }
}
