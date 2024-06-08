using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_rental
{
    public class Vehicle
    {
        private string id;
        private string carCompany;
        private int seatNum;
        private int yearOfPurchase;
        private long kilometersNum;
        private bool insurance;
        private Landlord landlord;
        protected double carStandardMoney = 200000;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string CarCompany
        {
            get { return carCompany; }
            set { carCompany = value; }
        }
        public int SeatNum
        {
            get { return seatNum; }
            set { seatNum = value; }
        }
        public int YearOfPurchase
        {
            get { return yearOfPurchase; }
            set { yearOfPurchase = value; }
        }
        public long KilometersNum
        {
            get { return kilometersNum; }
            set { kilometersNum = value; }
        }
        public bool Insurance
        {
            get { return insurance; }
            set { insurance = value; }
        }
        public double PriceOfOneDay
        {
            get { return carStandardMoney; }
            set { carStandardMoney = value; }
        }
        public Landlord Landlord
        {
            get { return landlord; }
            set { landlord = value; }
        }

        public Vehicle() { }
        public Vehicle(string id, string carCompany, int seatNum, int yearOfPurchase, long kilometersNum, bool insurance, Landlord landlord)
        {
            this.id = id;
            this.carCompany = carCompany;
            this.seatNum = seatNum;
            this.yearOfPurchase = yearOfPurchase;
            this.kilometersNum = kilometersNum;
            this.insurance = insurance;
            this.landlord = landlord;   
        }

        public Vehicle(string id, string carCompany, int seatNum, int yearOfPurchase, long kilometersNum, bool insurance)
        {
            this.id = id;
            this.carCompany = carCompany;
            this.seatNum = seatNum;
            this.yearOfPurchase = yearOfPurchase;
            this.kilometersNum = kilometersNum;
            this.insurance = insurance;
        }
        public virtual string  VehicalInfo()
        {
            return " ";
        }
        public virtual string Position()
        {
            return " ";
        }
        public virtual double Rentcost(int timerent)
        {
            return 0;
        }


    }
}
