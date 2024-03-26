using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift5
{
    internal class Manager
    {
        private GarageHandler GarageHandler = null!;
       
        internal Manager() { }

        internal void Run() 
        {
            Initialize();
            Execute();
        }

        private void Execute()
        {
            bool continueProgram = true;

            while (continueProgram)
            {
                UI.ShowMenu();
                continueProgram = GetCommand();
            }
        }

        private bool GetCommand()
        {
            var keyPressed = UI.GetKeyPressed();

            switch(keyPressed)
            {
                case ConsoleKey.Q:
                    return false;
                case ConsoleKey.D1:
                    var size = UI.CreateGarage();
                    GarageHandler.CreateGarage(size);
                    UI.GarageCreated(size);
                    return true;
                case ConsoleKey.D2:
                    UI.AddVehicle();
                    string input = UI.GetReadLine();
                    Console.WriteLine($"LicenseNumber : {input}");

                    //TODO: Let user select vehicle type.
                    //TODO: Let user select vehicle color.
                    //TODO: Let user select number of wheels.
                    //TODO: Let user select vehicle specific options.
                    //TODO: Catch exceptions and send text to UI to print.
                    if (GarageHandler.AddVehicle(input))
                    {
                        UI.VehicleAdded();
                    }
                    else
                    {
                        UI.VehicleNotAdded();
                    }
                    return true;
                case ConsoleKey.D3:
                    UI.RemoveVehicle();
                    input = UI.GetReadLine();

                    if (GarageHandler.RemoveVehicle(input))
                    {
                        //Show UI vehicle removed
                        UI.VehicleRemoved();
                    }
                    else
                    {
                        //Show UI vehicle was not in garage
                        UI.VehicleNotRemoved();
                    }
                    return true;
                //List all parked vehicles
                case ConsoleKey.D4:
                    var vehicles = GarageHandler.GetAllVehicles();
                    UI.ListCars(vehicles);
                    return true;
                //List vehicletypes & amount of each?
                case ConsoleKey.D5:
                    return true;
                //Search vehicle by licensenumber
                case ConsoleKey.D6:
                    return true;
                //Search vehicle in garage, multiple criteria
                case ConsoleKey.D7:
                    return true;
                //Create a garage and populate it with vehicles
                case ConsoleKey.D8:
                    return true;
            }

            return true;
        }

        private void Initialize()
        {
            this.GarageHandler = new GarageHandler();
           
        }
    }
}
