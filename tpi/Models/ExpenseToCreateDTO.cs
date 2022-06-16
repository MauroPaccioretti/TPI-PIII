using System.ComponentModel.DataAnnotations;
namespace tpi.Models
{
    public class ExpenseToCreateDTO
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }

    }
}
