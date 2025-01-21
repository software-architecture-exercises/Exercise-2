using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CalculatorWS.DataAccess
{
    public class CityDataAccess
    {
        private const string ConnectionString = "Server=THANHLAM;Database=world;Trusted_Connection=True;";

        public City GetCityByName(string cityName)
        {
            City city = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
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

        public List<City> GetCitiesByCountry(string countryCode)
        {
            List<City> cities = new List<City>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
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
}