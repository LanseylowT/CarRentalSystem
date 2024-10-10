using System;

namespace CarRentalSystem.Models
{
    public class Analytics
    {
        public int AnalyticsId { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalSales { get; set; }
        public int CustomerCount { get; set; }
    }
}