using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("8: Create garage & populate it.")
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
            Console.WriteLine($"\nGarage with size : {size} created.");
            Console.ReadLine(); 
        }

        internal static void AddVehicle()
        {
                Console.WriteLine("Enter licenseplate number : ");
        }

        internal static void RemoveVehicle() 
        {
            Console.WriteLine("Enter licenseplate number to remove : ");
        }

        internal static ConsoleKey GetKeyPressed() => Console.ReadKey(intercept: true).Key;

        internal static String GetReadLine() => Console.ReadLine()!;
    }
}