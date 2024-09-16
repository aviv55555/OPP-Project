using finalProjOOP.Backend.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProjOOP.Backend
{
    public class VehiclesManager
    {
        private static BindingList<Vehicle> vehicles;
        static VehiclesManager()
        {
            vehicles = FileUtiles.LoadVehiclesFromFile();   
        }

        public static void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }
        public static void SaveVehicles(object sender, FormClosingEventArgs e)
        {
            FileUtiles.SaveVehiclesToFile(vehicles);
        }
        static void LoadVehicles()
        {
            vehicles = FileUtiles.LoadVehiclesFromFile();
        }

        public static void saveVehicles(object sender, FormClosingEventArgs e)
        {
            FileUtiles.SaveVehiclesToFile(vehicles);
        }

        

        public static BindingList<Vehicle> GetVehicles()
        {
            return vehicles;
        }

        public static BindingList<T> GetSpecificVehicles<T>() where T : Vehicle
        {
            BindingList<T> specificVehicles = new BindingList<T>();
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle is T)
                {
                    specificVehicles.Add((T)vehicle);
                }
            }
            return specificVehicles;
        }
        public static int removeVehiclesById(int licenseNum)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.LicenseNum == licenseNum)
                {
                    VehiclesManager.vehicles.Remove(vehicle);
                    return 1;
                }
            }
            return 0;
        }
        private static void LoadVehiclesFromFile()
        {
            // Implement the logic to load vehicles from a file
        }

        private static void SaveVehiclesToFile()
        {
            // Implement the logic to save vehicles to a file
        }
    }
}







 
     
