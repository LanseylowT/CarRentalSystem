using System.Data;
using CarRentalSystem.Models;
using MySql.Data.MySqlClient;

namespace CarRentalSystem.Handlers.CommandHandlers
{
    public class InquiryCommandHandler
{
    private readonly string _connectionString;

    public InquiryCommandHandler(string connectionString)
    {
        _connectionString = connectionString;
    }

    // Add a new inquiry
    public void AddInquiry(Inquiry inquiry)
    {
        using (MySqlConnection conn = new MySqlConnection(_connectionString))
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand("AddInquiry", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_customerId", inquiry.CustomerId);
                cmd.Parameters.AddWithValue("p_carId", inquiry.CarId);
                cmd.Parameters.AddWithValue("p_status", inquiry.Status);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // Update an existing inquiry
    public void UpdateInquiry(Inquiry inquiry)
    {
        using (MySqlConnection conn = new MySqlConnection(_connectionString))
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand("UpdateInquiry", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_inquiryId", inquiry.InquiryId);
                cmd.Parameters.AddWithValue("p_customerId", inquiry.CustomerId);
                cmd.Parameters.AddWithValue("p_carId", inquiry.CarId);
                cmd.Parameters.AddWithValue("p_status", inquiry.Status);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // Delete an inquiry by ID
    public void DeleteInquiry(int inquiryId)
    {
        using (MySqlConnection conn = new MySqlConnection(_connectionString))
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand("DeleteInquiry", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_inquiryId", inquiryId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

}