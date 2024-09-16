using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProjOOP.Backend.model
{
    [Serializable]
    internal class MarineVehicle :Vehicle
    {
        public string Company { get; set; }
        public bool PrivateMarine { get; set; }
        public bool CommercialMarine { get; set; }

        public MarineVehicle(int licenseNum, string color, int year, int numSeats,string company, bool privateMarine, bool commercialMarine)
                : base(licenseNum, color, year, numSeats)
        {
            Company = company;
            PrivateMarine = privateMarine;
            CommercialMarine = commercialMarine;
        }
    }
}
