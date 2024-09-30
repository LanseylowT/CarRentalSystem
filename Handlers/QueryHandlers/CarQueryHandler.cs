using System.Collections.Generic;
using System.Data;
using CarRentalSystem.Models;
using MySql.Data.MySqlClient;

namespace CarRentalSystem.Handlers.QueryHandlers
{
    public class CarQueryHandler
    {
        private readonly string _connectionString;

        public CarQueryHandler(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        // Fetch all cars
        public List<Car> GetAllCars()
        {
            var cars = new List<Car>();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("GetAllCars", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cars.Add(new Car
                            {
                                CarId = (int)reader["ID"],
                                Brand = reader["brand"].ToString(),
                                Model = reader["model"].ToString(),
                                PricePerDay = (decimal)reader["pricePerDay"],
                                Availability = (bool)reader["availability"],
                                ImagePath = reader["imagePath"].ToString()
                            });
                        }
                    }
                }
            }

            return cars;
        }
        
        
        // Fetch a car by ID
        public Car GetCarById( int carId)
        {
            Car car = null;

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("GetCarById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_carId", carId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            car = new Car
                            {
                                CarId = (int)reader["ID"],
                                Brand = reader["brand"].ToString(),
                                Model = reader["model"].ToString(),
                                PricePerDay = (decimal)reader["pricePerDay"],
                                Availability = (bool)reader["availability"],
                                ImagePath = reader["imagePath"].ToString()
                            };
                        }
                    }
                }
            }

            return car;
        }
    }
}