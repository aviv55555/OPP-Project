using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProjOOP.Backend.model
{
    [Serializable]
    public abstract class LandVehicle : Vehicle
    {
        public string TypeFuel { get; set; }
        public int EngineCapacity { get; set; }

        protected LandVehicle(int licenseNum, string color, int year, int numSeats, string typeFuel, int engineCapacity)
            : base(licenseNum, color, year, numSeats)
        {
            TypeFuel = typeFuel;
            EngineCapacity = engineCapacity;
        }
    }
}
