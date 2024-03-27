using Uppgift5.Vehicles;

namespace Uppgift5
{
    public interface IGarage<T> where T : Vehicle
    {
        bool IsFull { get; }

        bool AddVehicle(T vehicle);
        string[] GetAllVehicles();
        IEnumerator<T> GetEnumerator();
        string GetVehicleByLicenseNumber(string licenseNumber);
        public bool IsVehicleInGarage(string licenseNumber);
        string[] GetVehicleTypesAndAmount();
        bool RemoveVehicle(string licenseNumber);
    }
}