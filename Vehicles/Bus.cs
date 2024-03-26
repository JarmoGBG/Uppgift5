using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift5.Vehicles
{
    internal class Bus : Vehicle
    {
        public uint NumberOfPassengers {  get; set; }   

        public Bus (string licenseNumber, VehicleEnums.VehicleColor vehicleColor, uint numberOfWheels, uint numberOfPassengers) : base(licenseNumber, vehicleColor, numberOfWheels)
        {
            NumberOfPassengers = numberOfPassengers;
        }

    }
}
