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

            //Move all elements after index one step to the left

            //Set last element to null

            //Reduce vehicleCount by 1

            //If removed, return true else return false

            return false;


            //TODO : Very bökig way of doing stuff? Do better
            //int removeAtIndex = 0;
            //bool found = false;
            
            //for (int i = 0; i < VehicleCount; i++)
            //{
            //    if (Vehicles[i].LicenseNumber == licenseNumber)
            //    {
            //        found = true;
            //        removeAtIndex = i;
            //    }
            //}

            //if (found)
            //{
            //    Vehicle[] newVehicleArray = new Vehicle[Capacity];

            //}
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
