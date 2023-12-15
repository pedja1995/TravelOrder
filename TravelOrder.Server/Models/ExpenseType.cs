using System.ComponentModel.DataAnnotations;

namespace TravelOrder.Server.Models
{
    public class ExpenseType
    {
        [Key]
        public int ExpenseTypeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Code { get; set; } = string.Empty;

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

     
    }
}
