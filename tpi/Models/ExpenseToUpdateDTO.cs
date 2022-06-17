using System.ComponentModel.DataAnnotations;

namespace tpi.Models
{
    public class ExpenseToUpdateDTO
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime? DatePaid { get; set; }

    }
}
