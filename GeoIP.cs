using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace C_Sharp_GeoIP
{
    class GeoIP
    {
        public string ip;
        public string countryCode;
        public string countryName;
        public string regionCode;
        public string regionName;
        public string city;
        public string latitude;
        public string longitude;

        public GeoIP()
        {

        }

        public void FetchInfo()
        {
            try
            {

                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://freegeoip.net/xml/");
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream stream = httpWebResponse.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string receivedString = reader.ReadToEnd();

                reader.Close(); stream.Close(); httpWebResponse.Close();

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(receivedString);

                ip = xmlDoc.SelectSingleNode("Response//Ip").InnerXml.ToString();
                countryCode = xmlDoc.SelectSingleNode("Response//CountryCode").InnerXml.ToString();
                countryName = xmlDoc.SelectSingleNode("Response//CountryName").InnerXml.ToString();
                regionCode = xmlDoc.SelectSingleNode("Response//RegionCode").InnerXml.ToString();
                regionName = xmlDoc.SelectSingleNode("Response//RegionName").InnerXml.ToString();
                city = xmlDoc.SelectSingleNode("Response//City").InnerXml.ToString();
                latitude = xmlDoc.SelectSingleNode("Response//Latitude").InnerXml.ToString();
                longitude = xmlDoc.SelectSingleNode("Response//Longitude").InnerXml.ToString();
            }
            catch 
            {

            }
        }
    }
}
