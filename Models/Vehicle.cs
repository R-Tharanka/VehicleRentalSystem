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

        public Vehicle(string regNumber, string brand, int year)
        {
            RegistrationNumber = regNumber;
            Brand = brand;
            Year = year;
        }

        // Virtual method for polymorphism
        public virtual string GetInfo()
        {
            return $"{Brand} ({Year}) - Reg#: {RegistrationNumber}";
        }
    }
}

