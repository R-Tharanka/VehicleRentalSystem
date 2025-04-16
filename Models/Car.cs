using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem.Models
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string regNumber, string brand, int year, int doors)
            : base(regNumber, brand, year)
        {
            NumberOfDoors = doors;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $" | Doors: {NumberOfDoors}";
        }
    }
}

