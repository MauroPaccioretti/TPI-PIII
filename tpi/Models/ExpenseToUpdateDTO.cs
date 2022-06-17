using System.ComponentModel.DataAnnotations;

namespace tpi.Models
{
    public class ExpenseToUpdateDTO
    {
        [Required]
        public DateTime? DatePaid { get; set; }

    }
}
