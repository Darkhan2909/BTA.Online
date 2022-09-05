using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTA.Online.BLL
{
    public class Adress
    {
        public string Country { get; set; }
        public string Street { get; set; }
        public string House { get; set; }

        public Adress(string Country, string Street, string House)
        {
            this.Country = Country;
            this.Street = Street;
            this.House = House;
        }
    }
}
