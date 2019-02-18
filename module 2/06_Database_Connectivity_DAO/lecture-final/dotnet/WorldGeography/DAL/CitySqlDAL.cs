using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CitySqlDAL
    {
        private string connectionString;

        public CitySqlDAL(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }
        
        public List<City> GetCitiesByCountryCode(string countryCode)
        {
            List<City> result = new List<City>();

            // define my sql statement
            string SqlCountryCodeCities = $"SELECT * FROM city WHERE countryCode = '{countryCode}' ORDER BY city.district, city.name;";

            // create my connection object
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // open connection
                conn.Open();

                // create my command object
                SqlCommand cmd = new SqlCommand(SqlCountryCodeCities, conn);

                // execute command
                SqlDataReader reader = cmd.ExecuteReader();

                // if applicable loop through result set
                while (reader.Read())
                {
                    // populate object(s) to return
                    City c = new City();
                    c.CityId = Convert.ToInt32(reader["id"]);
                    c.CountryCode = Convert.ToString(reader["countrycode"]);
                    c.District = Convert.ToString(reader["district"]);
                    c.Population = Convert.ToInt32(reader["population"]);
                    c.Name = Convert.ToString(reader["name"]);

                    result.Add(c);
                }
            }

            // return object(s)
            return result;
        }

    }
}
