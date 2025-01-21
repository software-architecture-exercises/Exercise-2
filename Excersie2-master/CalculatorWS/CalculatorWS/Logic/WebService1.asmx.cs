using CalculatorWS.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculatorWS.Logic
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        private readonly CityDataAccess _dataAccessCity = new CityDataAccess();
        private readonly CountryDataAccess _dataAccessCountry = new CountryDataAccess();

        [WebMethod]
        public City GetCityByName(string cityName)
        {
            return _dataAccessCity.GetCityByName(cityName);
        }

        [WebMethod]
        public List<City> GetCitiesByCountry(string countryCode)
        {
            return _dataAccessCity.GetCitiesByCountry(countryCode);
        }


        [WebMethod]
        public List<Country> GetAllCountries()
        {
            return _dataAccessCountry.GetAllCountries();
        }

        [WebMethod]
        public Country GetCountryByCode(string countryCode)
        {
            return _dataAccessCountry.GetCountryByCode(countryCode);
        }
    }
}
