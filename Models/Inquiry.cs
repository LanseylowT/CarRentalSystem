namespace CarRentalSystem.Models
{
    public class Inquiry
    {
        public int InquiryId { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public string Status { get; set; }
    }
}