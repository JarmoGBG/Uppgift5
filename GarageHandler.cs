using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift5.Vehicles;

namespace Uppgift5
{
    internal class GarageHandler
    {
        private Garage<Vehicle> Garage = null!;

        internal void CreateGarage(uint size)
        {
            Garage = new Garage<Vehicle>(size);
        }

        internal bool AddVehicle(string licenseNumber)
        {
            //TODO: Check if license number already in garage, return false if exists.
            Car vehicle = new Car(licenseNumber, VehicleEnums.VehicleColor.Black, 4, VehicleEnums.Fuel.Gasoline);
            var didItWork = Garage.AddVehicle(vehicle);
            return didItWork;
        }

        internal bool RemoveVehicle(string licenseNumber)
        {
            return Garage.RemoveVehicle(licenseNumber);
        }

        internal string[] GetAllVehicles()
        { 
            return Garage.GetAllVehicles();
        }
    }
}