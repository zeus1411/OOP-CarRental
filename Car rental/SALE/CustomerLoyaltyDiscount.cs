using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_rental
{
    public class CustomerLoyaltyDiscount : Sale
    {
        private int numberOfContracts;
        public int Numbers
        {
            get { return numberOfContracts; }
            set { numberOfContracts = value; }
        }
        public override double DiscountOrIncrease()
        {
            if (this.numberOfContracts >= 3)
            {
                return -5 / 100;
            }
            else return 0;
        }
    }
}
