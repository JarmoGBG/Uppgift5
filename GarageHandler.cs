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
        private IGarage<Vehicle> Garage = null!;

        internal void CreateGarage(uint size)
        {
            Garage = new Garage<Vehicle>(size);
        }

        internal bool AddVehicle(string licenseNumber)
        {
            if (Garage == null)
            {
                throw new NullReferenceException("Garage not initialized");
            }
            if (Garage.IsVehicleInGarage(licenseNumber))
            {
                return false;
            }
            Car vehicle = new Car(licenseNumber, VehicleEnums.VehicleColor.Black, 4, VehicleEnums.Fuel.Gasoline);
            var didItWork = Garage.AddVehicle(vehicle);
            return didItWork;
        }

        internal bool RemoveVehicle(string licenseNumber)
        {
            if(Garage ==null)
            {
                throw new NullReferenceException("Garage not initialized");
            }
            return Garage.RemoveVehicle(licenseNumber);
        }

        internal string[] GetAllVehicles()
        {
            if (Garage == null)
            {
                throw new NullReferenceException("Garage not initialized");
            }
            return Garage.GetAllVehicles();
        }

        internal string[] GetVehiclesAndAmount()
        {
            if (Garage == null)
            {
                throw new NullReferenceException("Garage not initialized");
            }
            return Garage.GetVehicleTypesAndAmount();
        }

        internal string GetVehicleByLicenseNumber(string licenseNumber)
        {
            if (Garage == null)
            {
                throw new NullReferenceException("Garage not initialized");
            }
            return Garage.GetVehicleByLicenseNumber(licenseNumber);
        }
    }
}