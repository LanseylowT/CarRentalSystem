using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using CarRentalSystem.Common;
using CarRentalSystem.Handlers.CommandHandlers;
using CarRentalSystem.Handlers.QueryHandlers;
using CarRentalSystem.Models;

namespace CarRentalSystem_Console
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            UserAccountTest();
        }

        private static void UserAccountTest()
        {
            var userQueryHandler = new UserAccountQueryHandler(Commons.ConnectionString);
            var userCommandHandler = new UserAccountCommandHandler(Commons.ConnectionString);
            
            // Register a new user
            var newUser = new UserAccount { UserName = "lansilot", Role = "Admin", Password = "Lansilot@123" };
            userCommandHandler.RegisterUser(newUser);
            Console.WriteLine("User Registered!");
        }

        private void CarTest()
        {
            string connectionString = "Server=localhost;Database=carrental;User ID=root;Password=Lansilot@123;";
            
            // Test CommandHandler
            var carCommandHandler = new CarCommandHandler(Commons.ConnectionString);
            var carQueryHandler = new CarQueryHandler(connectionString);
            
            // Add a new car
            var newCar = new Car
            {
                Brand = "Toyota",
                Model = "Corolla",
                PricePerDay = 800.00m,
                Availability = true,
                ImagePath = ""
            };
            
            // carCommandHandler.AddCar(newCar);
            // Console.WriteLine("New car added!");
            
            // Fetch all cars
            List<Car> cars = carQueryHandler.GetAllCars();
            Console.WriteLine("\nAll Cars:");

            foreach (var car in cars)
            {
                Console.WriteLine($"Car ID: {car.CarId}, Brand: {car.Brand}, Model: {car.Model}, Price: {car.PricePerDay}, Available: {car.Availability}");
            }


        }
    }
}