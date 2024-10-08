﻿using System;
using System.Data;
using System.IO;
using DotNetEnv;
using MySql.Data.MySqlClient;

namespace CarRentalSystem.Common
{
    public static class Commons
    {
        private static readonly string dbUser;
        private static readonly string dbPassword;
        public static readonly string ConnectionString;

        static Commons()
        {
            Env.Load(Path.Combine("..", "..", ".env"));
            // ListAllEnvironmentVariables();
            dbUser = Environment.GetEnvironmentVariable("db_username");
            dbPassword = Environment.GetEnvironmentVariable("db_password");
            ConnectionString = $"Server=localhost;Database=carrental;User ID={dbUser};Password={dbPassword}";
        }

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