using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem.Models
{
    public class Motorbike : Vehicle
    {
        public bool HasSideCar { get; set; }

        public Motorbike(string regNumber, string brand, int year, bool hasSideCar)
            : base(regNumber, brand, year)
        {
            HasSideCar = hasSideCar;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $" | Sidecar: {(HasSideCar ? "Yes" : "No")}";
        }
    }
}

