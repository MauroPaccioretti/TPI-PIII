namespace tpi.Models
{
    public class ExpenseDTO
    {
        public int Id { get; set; }
        public int LandId { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? DatePaid { get; set; }
        public double TotalCost { get; set; }

    }
}
