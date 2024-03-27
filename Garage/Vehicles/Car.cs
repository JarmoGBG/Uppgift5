using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift5.Vehicles
{
    public class Car : Vehicle
    {
        public VehicleEnums.Fuel FuelType {  get; set; }
        
        public Car (string licenseNumber, VehicleEnums.VehicleColor color, uint numberOfWheels, VehicleEnums.Fuel fuelType): base(licenseNumber, color, numberOfWheels)
        {
            FuelType = fuelType;
        }
    }
}
