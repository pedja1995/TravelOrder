using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelOrder.Server.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }

        [Required]
        [ForeignKey(nameof(ExpenseType))]
        public int ExpenseTypeId { get; set; }

        [Required]
        [ForeignKey(nameof(TravelOrder))]
        public int TravelOrderId { get; set; }

        [Required]
        public double Value { get; set; }

        [MaxLength(150)]
        public string Note { get; set; } = string.Empty;


        public virtual ExpenseType ExpenseType { get; set; }

        public virtual TravelOrder TravelOrder { get; set; }


    }
}
