using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using CarRentalSystem.Handlers.CommandHandlers;
using CarRentalSystem.Handlers.QueryHandlers;
using CarRentalSystem.Models;

namespace CarRentalSystem_Console
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=carrental;User ID=root;Password=Lansilot@123;";
            
            // Test CommandHandler
            var carCommandHandler = new CarCommandHandler(connectionString);
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