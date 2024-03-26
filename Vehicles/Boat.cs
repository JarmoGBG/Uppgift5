using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift5.Vehicles
{
    internal class Boat : Vehicle
    {
        public VehicleEnums.BoatType TypeOfBoat { get; set; }

        public Boat(string licenseNumber, VehicleEnums.VehicleColor color, uint numberOfWheels, VehicleEnums.BoatType boatType) :base(licenseNumber, color, numberOfWheels)
        {
            TypeOfBoat = boatType;
        }
    }
}
