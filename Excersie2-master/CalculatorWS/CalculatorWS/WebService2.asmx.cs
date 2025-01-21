using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculatorWS
{
    /// <summary>
    /// Summary description for WebService2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService2 : System.Web.Services.WebService

    {

        [WebMethod]
        public List<Country> GetAllCountries()
        {
            List<Country> countries = new List<Country>();
            string connectionString = "Server=THANHLAM;Database=world;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM country";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    countries.Add(new Country
                    {
                        Code = reader["Code"].ToString(),
                        Name = reader["Name"].ToString(),
                        Continent = reader["Continent"].ToString(),
                        Population = Convert.ToInt32(reader["Population"])
                    });
                }
            }

            return countries;
        }

        [WebMethod]
        public Country GetCountryByCode(string countryCode)
        {
            Country country = null;
            string connectionString = "Server=THANHLAM;Database=world;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM country WHERE Code = @Code";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Code", countryCode);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    country = new Country
                    {
                        Code = reader["Code"].ToString(),
                        Name = reader["Name"].ToString(),
                        Continent = reader["Continent"].ToString(),
                        Population = Convert.ToInt32(reader["Population"])
                    };
                }
            }

            return country;
        }

        [WebMethod]
        public City GetCityByName(string cityName)
        {
            City city = null;
            string connectionString = "Server=THANHLAM;Database=world;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM city WHERE Name = @Name";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", cityName);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    city = new City
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Name = reader["Name"].ToString(),
                        CountryCode = reader["CountryCode"].ToString(),
                        District = reader["District"].ToString(),
                        Population = Convert.ToInt32(reader["Population"])
                    };
                }
            }

            return city;
        }

        [WebMethod]
        public List<City> GetCitiesByCountry(string countryCode)
        {
            List<City> cities = new List<City>();
            string connectionString = "Server=THANHLAM;Database=world;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM city WHERE CountryCode = @CountryCode";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CountryCode", countryCode);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cities.Add(new City
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Name = reader["Name"].ToString(),
                        CountryCode = reader["CountryCode"].ToString(),
                        District = reader["District"].ToString(),
                        Population = Convert.ToInt32(reader["Population"])
                    });
                }
            }

            return cities;
        }


    }

    public class Country
    {
        public string Code { get; set; }            // Mã quốc gia
        public string Name { get; set; }            // Tên quốc gia
        public string Continent { get; set; }       // Châu lục
        public string Region { get; set; }          // Khu vực
        public decimal SurfaceArea { get; set; }    // Diện tích bề mặt
        public short? IndepYear { get; set; }       // Năm độc lập (nullable)
        public int Population { get; set; }         // Dân số
        public decimal? LifeExpectancy { get; set; } // Tuổi thọ trung bình (nullable)
        public decimal? GNP { get; set; }           // Tổng sản phẩm quốc nội (GNP) (nullable)
        public decimal? GNPOld { get; set; }        // GNP cũ (nullable)
        public string LocalName { get; set; }       // Tên địa phương
        public string GovernmentForm { get; set; }  // Hình thức chính phủ
        public string HeadOfState { get; set; }     // Nguyên thủ quốc gia (nullable)
        public int? Capital { get; set; }           // ID thủ đô (nullable)
        public string Code2 { get; set; }           // Mã quốc gia 2 ký tự
    }

    public class City
    {
        public int ID { get; set; }                 // ID thành phố
        public string Name { get; set; }            // Tên thành phố
        public string CountryCode { get; set; }     // Mã quốc gia
        public string District { get; set; }        // Quận/Huyện
        public int Population { get; set; }         // Dân số
    }

}
