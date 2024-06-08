using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_rental
{
    public class Promotion:Sale
    {
        public override double DiscountOrIncrease()
        {
            if(DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                return 0.05;
            }
            else
            {
                return -0.02;
            }
        }
    }
}
