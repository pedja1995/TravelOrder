using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelOrder.Server.Models
{
    public class DepartmentEmployee
    {
        [Key]
        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }

        [Key]
        [ForeignKey(nameof(Employee))]
        public Guid EmployeeId { get; set; }

        [Key]
        [ForeignKey(nameof(Position))]
        public int PositionId { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Department Department { get; set; }

        public virtual Position Position { get; set;}




    }
}
