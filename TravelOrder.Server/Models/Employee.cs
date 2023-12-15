using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelOrder.Server.Models
{
    public class Employee
    {
        [Key]
        [ForeignKey(nameof(User))]
        public Guid EmployeeId { get; set; }

        [ForeignKey(nameof(Manager))]
        public Guid ManagerId { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public string ParentName { get; set; } = string.Empty;

        public virtual User User { get; set; }

        public virtual Employee Manager { get; set; }

        public virtual ICollection<TravelOrder>? TravelOrders { get; set; }

        public virtual ICollection<DepartmentEmployee> DepartmentEmployees { get; set; }

    }
}
