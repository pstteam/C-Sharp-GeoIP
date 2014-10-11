using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_GeoIP
{
    class Program
    {
        static void Main(string[] args)
        {
            GeoIP geoIP = new GeoIP();
            geoIP.FetchInfo();

            Console.WriteLine("IP: \t\t" + geoIP.ip);
            Console.WriteLine("Country Code: \t" + geoIP.countryCode);
            Console.WriteLine("Country Name: \t" + geoIP.countryName);
            Console.WriteLine("Region Code: \t" + geoIP.regionCode);
            Console.WriteLine("Region Name: \t" + geoIP.regionName);
            Console.WriteLine("City: \t\t" + geoIP.city);
            Console.WriteLine("Latitude: \t" + geoIP.latitude);
            Console.WriteLine("Longitude: \t" + geoIP.longitude);

            Console.ReadLine();
        }
    }
}
