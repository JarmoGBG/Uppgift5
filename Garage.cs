using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift5.Vehicles;

namespace Uppgift5
{
    //TODO: Make test cases for all public methods
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private Vehicle[] Vehicles;
        private readonly uint Capacity;
        public uint VehicleCount = 0;
        public bool IsFull => VehicleCount == Capacity;

        public Garage(uint capacity)
        {
            Capacity = capacity;
            Vehicles = new Vehicle[capacity];
        }

        /// <summary>
        /// Add a vehicle to Vehicles
        /// </summary>
        /// <param name="Vehicle">The vehicle to add.</param>
        /// <returns>True if vehicle could be added, false if array is already full</returns>
        public bool AddVehicle(T vehicle)
        {
            if (IsFull)
            {
                return false;
            }
            else
            {
                Vehicles[VehicleCount] = vehicle;
                VehicleCount++;
                return true;
            }
        }

        /// <summary>
        /// Remove vehicle from garage 
        /// </summary>
        /// <param name="licenseNumber">The licensenumber of the vehicle to remove</param>
        /// <returns>True if the vehicle was in the garage and removed, false otherwise</returns>
        public bool RemoveVehicle(string licenseNumber)
        {
            licenseNumber = licenseNumber.ToUpper();

            //Vehicles = Vehicles.Where(vehicle => vehicle != null).Where(vehicle => vehicle.LicenseNumber != licenseNumber).ToArray();

            //Find which index the licensenumber element is at
            int index = -1;
            for (int i = 0; i < VehicleCount; i++)
            {
                if (Vehicles[i].LicenseNumber.Equals(licenseNumber))
                {
                    index = i;
                }
            }

            if (index > -1)
            {
                //Move all elements after index one step to the left
                for (int i = index; i < VehicleCount; i++)
                {
                    Vehicles[i] = Vehicles[i + 1];
                }

                //Reduce vehicleCount by 1
                VehicleCount--;
            }

            //If removed, return true else return false
            if (index >= 0)
            {
                return true;
            }

            return false;
        }

        public string[] GetAllVehicles()
        {
            string[] vehicles = new string[VehicleCount];
            Vehicle vehicle = null;

            for (int i = 0; i < VehicleCount; i++)
            {
                vehicle = Vehicles[i];
                vehicles[i] = CreateVehicleString(vehicle);
            }

            return vehicles;
        }

        /// <summary>
        /// Get vehicle by licensenumber
        /// </summary>
        /// <param name="licenseNumber"></param>
        /// <returns>String with vehicle data if found, null otherwise</returns>
        public string GetVehicleByLicenseNumber(string licenseNumber)
        {
            licenseNumber = licenseNumber.ToUpper();
            for(int i = 0; i < VehicleCount; i++)
            {
                if (Vehicles[i].LicenseNumber.Equals(licenseNumber))
                {
                    return CreateVehicleString(Vehicles[i]);
                }
            }
            return null;
        }

        private string CreateVehicleString(Vehicle vehicle)
        {
            //TODO : Add subclass specific info
            return new string($"{vehicle.GetType().Name}, Licensenumber:{vehicle.LicenseNumber}, Color:{vehicle.VehicleColor.ToString()}, Number of wheels:{vehicle.NumberOfWheels}");
        }

        public string[] GetVehicleTypesAndAmount()
        {
            //Populate array with all vehicle types and count how many of each type in garage.
            return null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(var vehicle in Vehicles)
            {
                yield return (T)vehicle;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
