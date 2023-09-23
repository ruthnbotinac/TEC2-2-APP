using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class Location
    {
        private long latitud;
        private long longitud;
        private string city;
        private string country;
        private string region;
        private string updatelocation;

        public long Latidud
        {
            get { return latitud; }
            set {   latitud = value; }
        }
        public long Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        
        }
        public string Country
        {
            get { return country; } 
            set { country = value; }
        }
        public string Region
        {
            get { return region; }
            set { region = value; }
        }
        public string Updatelocation
        {
            get { return updatelocation; }
            set { updatelocation = value; }
        }

    }
}
