using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProjOOP.Backend.model
{
    [Serializable]
    public class Car : LandVehicle
    {
        public int DoorsNum { get; set; }
        public string Company { get; set; }
        public string GearType { get; set; }

        public Car(int licenseNum, string color, int year, int numSeats, string typeFuel, int engineCapacity, int doorsNum, string company, string gearType)
            : base(licenseNum, color, year, numSeats, typeFuel, engineCapacity)
        {
            DoorsNum = doorsNum;
            Company = company;
            GearType = gearType;
        }
    }

}
