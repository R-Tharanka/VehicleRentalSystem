using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem.Models
{
    public class Vehicle
    {
        public string RegistrationNumber { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }

        private bool isRented; // encapsulated

        public Vehicle(string regNumber, string brand, int year)
        {
            RegistrationNumber = regNumber;
            Brand = brand;
            Year = year;
            isRented = false;
        }

        public bool IsRented => isRented;

        public void Rent()
        {
            if (!isRented)
                isRented = true;
        }

        public void Return()
        {
            if (isRented)
                isRented = false;
        }

        public virtual string GetInfo()
        {
            string status = isRented ? "Rented" : "Available";
            return $"{RegistrationNumber,-10} | {Brand,-10} | {Year,-4} | {status,-9}";
        }

    }
}


