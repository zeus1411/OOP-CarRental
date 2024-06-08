using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_rental
{
    class Contract
    {
        private string id;
        private Customers customers;
        private Vehicle vehicle;
        private int numberOfDays;
        private string purpose;
        private double deposit;
        private DateTime rentalDate;
        private bool isDone;
        private double total;

        public Customers Customers
        {
            get { return customers; }
            set { customers = value; }
        }
        public Vehicle Vehicle
        {
            get { return vehicle; }
            set { vehicle = value; }
        }
        public int NumberOfDays
        {
            get { return numberOfDays; }
            set { numberOfDays = value; }
        }
        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public double Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public DateTime RentalDate
        {
            get { return rentalDate; }
            set { rentalDate = value; }
        }

        public bool IsDone
        {
            get { return isDone; }
            set { isDone = value; }
        }
        public Contract() { }
        public Contract(string id, Customers customers, Vehicle vehicle, int numberOfDays, string purpose, double deposit, DateTime rentalDate, bool isDone, double total)
        {
            this.id = id;
            this.customers = customers;
            this.vehicle = vehicle;
            this.numberOfDays = numberOfDays;
            this.purpose = purpose;
            this.deposit = deposit;
            this.rentalDate = rentalDate;
            this.isDone = isDone;
            this.total = total;
        }
        
        public Contract(Customers customers, Vehicle vehicle, int numberOfDays, string purpose, double deposit, DateTime rentalDate)
        {
            this.customers = customers;
            this.vehicle = vehicle;
            this.numberOfDays = numberOfDays;
            this.purpose = purpose;
            this.deposit = deposit;
            this.rentalDate = rentalDate;
        }
       

    }
}
