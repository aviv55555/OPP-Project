using finalProjOOP.Backend.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace finalProjOOP.Backend
{
    public class FileUtiles
    {
        public static void SaveVehiclesToFile(BindingList<Vehicle> vehicles)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fi = new FileInfo("vehicles.bin");
            using (var binaryFile = fi.Create())
            {
                binaryFormatter.Serialize(binaryFile, vehicles);
                binaryFile.Flush();
            }
        }

        public static BindingList<Vehicle> LoadVehiclesFromFile()
        {
            BindingList<Vehicle> vehicles;
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileInfo fi = new System.IO.FileInfo("vehicles.bin");
                using (var binaryFile = fi.OpenRead())
                {
                    vehicles = (BindingList<Vehicle>)binaryFormatter.Deserialize(binaryFile);
                }
            }

            catch (Exception ex)
            {
                vehicles = new BindingList<Vehicle>();
            }
            return vehicles;
        }
    }
}

