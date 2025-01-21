using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CalculatorWS.DataAccess
{
    public class CountryDataAccess
    {
        private const string ConnectionString = "Server=THANHLAM;Database=world;Trusted_Connection=True;";

        public List<Country> GetAllCountries()
        {
            List<Country> countries = new List<Country>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
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

        public Country GetCountryByCode(string countryCode)
        {
            Country country = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
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
    }
}