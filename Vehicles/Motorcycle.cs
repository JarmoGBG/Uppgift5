using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift5.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public bool IsAHarley { get; set; }

        public Motorcycle(string licenseNumber, VehicleEnums.VehicleColor vehicleColor, uint numberOfWheels, bool isAHarley) : base (licenseNumber, vehicleColor, numberOfWheels)
        {
            IsAHarley = isAHarley;
        }
    }
}
