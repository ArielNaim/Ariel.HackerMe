using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariel.HackerMe.DB
{
    public class City
    {
        public static int Id { get; set; }
        public static string  CityName { get; set; }

        public static List<City> Cities = new List<City>();
    }
}
