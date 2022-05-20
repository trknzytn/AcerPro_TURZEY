using AcerPro.Business.CountryInfoService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcerPro.Business
{
    public class CountryInfoManager
    {
        CountryInfoServiceSoapTypeClient client = new CountryInfoServiceSoapTypeClient();
        public IEnumerable<tCountryCodeAndName> ListOfCountryNamesByCode()
        {
            var listOfCountryNames = client.ListOfCountryNamesByCode();
            return listOfCountryNames;
        }

        public string CountryISOCode(string country)
        {
            string countryISOCode = client.CountryISOCode(country);
            return countryISOCode;
        }


        public string CapitalCity(string code)
        {
            string capitalCity = client.CapitalCity(code);
            return capitalCity;
        }

        public tCurrency CountryCurrency(string code)
        {
            tCurrency countryCurrency = client.CountryCurrency(code);
            return countryCurrency;
        }
    }
}
