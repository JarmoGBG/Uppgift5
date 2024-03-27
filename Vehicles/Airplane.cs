using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift5.Vehicles
{
    public class Airplane : Vehicle
    {
        public bool IsAPropellerPlane {  get; set; }

        public Airplane(string licenseNumber, VehicleEnums.VehicleColor vehicleColor, uint numberOfWheels, bool isAPropellerPlane) : base(licenseNumber,vehicleColor, numberOfWheels)
        {
            IsAPropellerPlane = isAPropellerPlane;
        }
    }
}
