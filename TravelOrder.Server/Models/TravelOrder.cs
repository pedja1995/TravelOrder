using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelOrder.Server.Models
{
    public class TravelOrder
    {
        [Key]
        public int TravelOrderId { get; set; }

        [ForeignKey(nameof(Employee))]
        public Guid EmployeeId {  get; set; }


        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        [MaxLength(150)]
        public string Note { get; set; } = string.Empty;

        public DateTime? DateCreated { get; set; } = DateTime.Now;

        public virtual Employee Employee { get; set; }

        public virtual ICollection<Expense> Expenses { get; set;}



    }
}
