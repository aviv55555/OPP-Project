using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProjOOP.Backend.model
{
    [Serializable]
    public class Motorcycle : LandVehicle
    {
        public string Company { get; set; }
        public int NumOfWheels { get; set; }
        

        public Motorcycle(int licenseNum, string color, int year, int numSeats, string typeFuel, int engineCapacity, string company, int numOfWheels)
           : base(licenseNum, color, year, numSeats, typeFuel, engineCapacity)
        {
     
            Company = company;
            NumOfWheels = numOfWheels;
        }
    }
}
