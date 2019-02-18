using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class LanguageSqlDAL
    {
        private string connectionString;
        private const string SQL_InsertLanguage = @"insert into countrylanguage values (@countryCode, @language, @isOfficial, @percentage);";
        private const string SQL_LanguagesByCountry = @"select *  from countrylanguage  where countrycode = @countryCode and isofficial = @isOfficial;";
        private const string SQL_DeleteLanguage = "DELETE FROM countryLanguage WHERE countryCode = @countryCode AND language = @language";
        private const string _getLastIdSQL = "SELECT CAST(SCOPE_IDENTITY() as int);";


        public LanguageSqlDAL(string databaseConnectionString)
        {
            connectionString = databaseConnectionString;
        }

        public List<Language> GetLanguages(string countryCode, bool officialOnly)
        {
            throw new NotImplementedException();
        }

        public bool AddNewLanguage(Language newLanguage)
        {
            // define my sql statement
            string SqlAddNewLanguage = $"Insert Into countrylanguage (countrycode, language, isofficial, percentage) " +
                                       $"Values (@CountryCode,@Language,@IsOfficial,@Percentage)";

            int numRows = 0;

            // create my connection object
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // open connection
                conn.Open();

                // create my command object
                SqlCommand cmd = new SqlCommand(SqlAddNewLanguage, conn);
                cmd.Parameters.AddWithValue("@CountryCode", newLanguage.CountryCode);
                cmd.Parameters.AddWithValue("@Language", newLanguage.Name);
                cmd.Parameters.AddWithValue("@IsOfficial", newLanguage.IsOfficial);
                cmd.Parameters.AddWithValue("@Percentage", newLanguage.Percentage);

                // execute command
                numRows = cmd.ExecuteNonQuery();
            }
            
            return numRows == 0 ? false : true;
        }

        public bool RemoveLanguage(Language deadLanguage)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new department.
        /// </summary>
        /// <param name="newDepartment">The department object.</param>
        /// <returns>The id of the new department (if successful).</returns>
        //public int CreateDepartment(Department newDepartment)
        //{
        //    int id = 0;

        //    // define my sql statement
        //    string SqlCreateDepartment = $"Insert Into department (name) " +
        //                               $"Values ('{newDepartment.Name}');" +
        //                               _getLastIdSQL;

        //    // create my connection object
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        // open connection
        //        conn.Open();

        //        // create my command object
        //        SqlCommand cmd = new SqlCommand(SqlCreateDepartment, conn);

        //        // execute command
        //        id = (int)cmd.ExecuteScalar();
        //    }

        //    return id;
        //}
    }
}
