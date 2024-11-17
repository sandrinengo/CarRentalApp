using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp.Models
{
    public class RentInfo
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public string LicenseNumber { get; set; }
        public int Year { get; set; }
    }
}
