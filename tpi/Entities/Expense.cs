using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpi.Entities
{
    public class Expense
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("LandId")]
        public Land? Land { get; set; }
        public int LandId { get; set; }
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime? ExpirationDate { get; set; }
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime? DatePaid { get; set; }
        public double TotalCost { get; set; }

        public Expense(int id, int landId, DateTime? expirationDate, DateTime? datePaid, double totalCost)
        {
            Id = id;
            LandId = landId;
            ExpirationDate = expirationDate;
            DatePaid = datePaid;
            TotalCost = totalCost;
        }
    }
}
