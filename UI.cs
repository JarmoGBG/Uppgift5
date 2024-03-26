using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift5.Vehicles;

namespace Uppgift5
{
    internal static class UI
    {
        internal static void ShowMenu()
        {
            //Console.Clear();
            Console.WriteLine("\nGARAGE MENU");
            Console.WriteLine("1: Create a garage.");
            Console.WriteLine("2: Add vehicle to garage.");
            Console.WriteLine("3: Remove vehicle from garage.");
            Console.WriteLine("4: List all parked vehicles.");
            Console.WriteLine("5: List vehicletypes and numbers.");
            Console.WriteLine("6: Search vehicle by license number");
            Console.WriteLine("7: Search vehicle in garage.");
            Console.WriteLine("8: Create garage & populate it.");
            Console.WriteLine("Q: Quit program.");
        }

        internal static uint CreateGarage()
        {
            do
            {
                Console.WriteLine("\nInput size of garage:");
                var size = Console.ReadLine();
                uint result;
                if (uint.TryParse(size, out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("\nSize must be a positive integer");
                }
            } while (true);
        }

        internal static void GarageCreated(uint size)
        {
            Console.WriteLine($"Garage with size : {size} created.");
            Console.ReadLine(); 
        }

        internal static void AddVehicle()
        {
                Console.WriteLine("\nEnter licenseplate number : ");
        }

        internal static void VehicleAdded()
        {
            Console.WriteLine("Vehicle added to garage");
        }

        internal static void VehicleNotAdded()
        {
            Console.WriteLine("Vehicle was not added to garage because it was already full");
        }

        internal static void RemoveVehicle() 
        {
            Console.WriteLine("\nEnter licenseplate number to remove : ");
        }

        internal static void VehicleRemoved()
        {
            Console.WriteLine("Vehicle was removed from garage");
        }

        internal static void VehicleNotRemoved()
        {
            Console.WriteLine("Vehicle was not removed from garage, because it was not parked");
        }

        internal static void ListCars(string[] vehicles)
        {
            Console.WriteLine("\nCars in garage :");

            foreach(string vehicle in vehicles) 
            {
                Console.WriteLine($"{vehicle}");
            }
        }

        internal static ConsoleKey GetKeyPressed() => Console.ReadKey(intercept: true).Key;

        internal static String GetReadLine() => Console.ReadLine()!;
    }
}