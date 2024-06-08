using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_rental
{
    class Scratch:AdditionalCost
    {
        public override double CostAmount()
        {
            return 150000;
        }
    }
}
