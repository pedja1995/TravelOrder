using System.ComponentModel.DataAnnotations;

namespace TravelOrder.Server.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Code { get; set; } = string.Empty;

        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        public virtual ICollection<DepartmentEmployee> DepartmentEmployees { get; set; }

    }
}
