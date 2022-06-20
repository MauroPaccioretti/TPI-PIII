namespace tpi.Models
{
    public class ExpenseUnpaidDTO
    {
        public int Id { get; set; }
        public int LandId { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? DatePaid { get; set; }
        public double TotalCost { get; set; }

    }
}
