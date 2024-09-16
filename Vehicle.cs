using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProjOOP.Backend.model
{
    [Serializable]
    public abstract class Vehicle
    {
        public int LicenseNum { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int NumSeats { get; set; }

        protected Vehicle(int licenseNum, string color, int year, int numSeats)
        {
            LicenseNum = licenseNum;
            Color = color;
            Year = year;
            NumSeats = numSeats;
        }
    }
}
