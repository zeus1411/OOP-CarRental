using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_rental
{
    class FourSeatCar:Vehicle
    {
		private double priceOfOneDay = 450000;
        public new double PriceOfOneDay
        {
            get { return priceOfOneDay; }
            set { priceOfOneDay = value; }

        }
        public FourSeatCar(string id, string carCompany, int seatNum, int yearOfPurchase, long kilometersNum, bool insurance, Landlord landlord) : base(id, carCompany, seatNum, yearOfPurchase, kilometersNum, insurance, landlord)
        {

        }
        public FourSeatCar(string id, string carCompany, int seatNum, int yearOfPurchase, long kilometersNum, bool insurance) : base(id, carCompany, seatNum, yearOfPurchase, kilometersNum, insurance)
        {

        }
        public override string VehicalInfo()
        {
            return $"{Position()} | {ID} | {CarCompany} | {SeatNum} | {YearOfPurchase} | {KilometersNum} | {Insurance} |";
        }
        public override string Position()
        {
            return " Xe 4 cho ";
        }
        public override double Rentcost(int timeRent)
        {
            return ((timeRent * priceOfOneDay));
        }

    }
}
