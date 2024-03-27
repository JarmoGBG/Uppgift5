using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices;
using Uppgift5;
using Uppgift5.Vehicles;

namespace Uppgift5.MSTests
{
    [TestClass]
    public class GarageTest
    {
        [TestMethod]
        public void Constructor_SetsCapacity_IsNotFull()
        {
            uint capacity = 20;

            //Act 
            var garage = new Garage<Vehicle>(capacity);

            //Assert
            Assert.IsFalse(garage.IsFull);
        }

        [TestMethod]
        public void AddVehicle_SucceedsAndVehicleCountIs1()
        {
            uint capacity = 10;
            uint count = 1;

            var vehicle = new Car("ABC123", VehicleEnums.VehicleColor.Black, 4, VehicleEnums.Fuel.Gasoline);
            var garage = new Garage<Vehicle>(capacity);
            garage.AddVehicle(vehicle);

            Assert.IsFalse(garage.IsFull);
            Assert.AreEqual(count, garage.VehicleCount);
        }
    }
}