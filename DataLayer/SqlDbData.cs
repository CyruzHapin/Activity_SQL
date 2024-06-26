using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SqlDbData
    {
        static string connectionString
            = "Data Source = LAPTOP-H6PN7ITJ\\SQLEXPRESS; Initial Catalog = RestaurantMenu; Integrated Security = True;";

        static SqlConnection sqlConnection = new SqlConnection(connectionString);

        public static void Connect()
        {
            sqlConnection.Open();
        }

        public static List<Menu> GetUsers()
        {
            string selectStatement = "SELECT Description, Meal, Price, Drinks FROM RestoInfo";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            List<Menu> RestoInfo = new List<Menu>();

            while (reader.Read())
            {
                string Description = reader["Description"].ToString();
                string Meal = reader["Meal"].ToString();
                string Price = reader["Price"].ToString();
                string Drinks = reader["Drinks"].ToString();

                Menu readUser = new Menu();
                readUser.Description = Description;
                readUser.Meal = Meal;
                readUser.Price = Price;
                readUser.Drinks = Drinks;

                RestoInfo.Add(readUser);
            }

            sqlConnection.Close();

            return RestoInfo;
        }
        public static int AddUser(string Description, string Meal, string Price, string Drinks)
        {
            int success;

            string insertStatement = "INSERT INTO RestoInfo VALUES (@Description, @Meal, @Price, @Drinks )";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@Description", Description);
            insertCommand.Parameters.AddWithValue("@Meal", Meal);
            insertCommand.Parameters.AddWithValue("@Price", Price);
            insertCommand.Parameters.AddWithValue("@Drinks", Drinks);
            sqlConnection.Open();

            success = insertCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }
    }
}
