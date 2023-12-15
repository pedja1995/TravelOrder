using System.ComponentModel.DataAnnotations;

namespace TravelOrder.Server.Models
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        public bool IsActive { get; set; }
        public string PhoneNumber { get; set; }
        = string.Empty;
    }
}
