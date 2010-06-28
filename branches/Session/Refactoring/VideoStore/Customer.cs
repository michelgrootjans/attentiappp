using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    public class Customer
    {
        private string name;
        private List<Rental> rentals = new List<Rental>();

        public Customer(string name)
        {
            this.name = name;
        }

        public void AddRental(Rental rental)
        {
            rentals.Add(rental);
        }

        public string Name
        {
            get { return name; }
        }

        public string Statement()
        {
            var result = "Rental Record for " + Name + "\n";

            foreach (var rental in rentals)
            {
                //show figures for this rental
                result += "\t" + rental.Movie.Title + "\t" + rental.GetCharge() + "\n";
            }

            //add footer lines
            result += "Amount owed is " + GetTotalCharge() + "\n";
            result += "You earned " + GetFrequentRenterPoints() + " frequent renter points";
            return result;
        }

        private int GetFrequentRenterPoints()
        {
            return rentals.Sum(r => r.GetFrequentRenterPoints());
        }

        private double GetTotalCharge()
        {
            return rentals.Sum(r => r.GetCharge());
        }
    }
}