using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift5.Vehicles
{
    public abstract class Vehicle
    {
        private string licenseNumber;
        public string LicenseNumber
        {
            get => licenseNumber;
            set
            {
                licenseNumber = value.ToUpper();
            }
        }

        public VehicleEnums.VehicleColor VehicleColor { get; set; }

        public uint NumberOfWheels { get; set; }

        protected Vehicle(string licenseNumber, VehicleEnums.VehicleColor vehicleColor, uint numberOfWheels)
        {
            LicenseNumber = licenseNumber;
            VehicleColor = vehicleColor;
            NumberOfWheels = numberOfWheels;
        }
    }
}
