using finalProjOOP.Backend;
using finalProjOOP.Backend.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProjOOP.Backend
{
    public class LandVehiclesManager : VehiclesManager
    {
        private static BindingList<LandVehicle> landVehicles;

        public static void AddLandVehicle(LandVehicle landVehicle)
        {
            landVehicles = new BindingList<LandVehicle>();

        }
        public static BindingList<LandVehicle> GetLandVehicles()
        {
            return landVehicles;
        }

        public static BindingList<T> GetSpecificLandVehicles<T>() where T : LandVehicle
        {
            BindingList<T> specificVehicles = new BindingList<T>();
            foreach (LandVehicle landVehicle in landVehicles)
            {
                if (landVehicle is T)
                {
                    specificVehicles.Add(landVehicle as T);
                }
            }
            return specificVehicles;
        }
    }
}