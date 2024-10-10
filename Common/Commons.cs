using System.Data;
using MySql.Data.MySqlClient;

namespace CarRentalSystem.Common
{
    public static class Commons
    {
        public static string ConnectionString = "Server=localhost;Database=carrental;User ID=root;Password=Lansilot@123;";

        private static void ResetAutoIncrements()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("ResetAutoIncrement", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}