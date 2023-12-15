using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelOrder.Server.Models
{
    public class Document
    {
        [Key]
        public Guid DocumentId { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(TravelOrder))]
        public int TravelOrderId { get; set; }

        public DateTime DateCreated { get; set; }

        public string Name { get; set; } = string.Empty;

        public virtual User User { get; set; }

        public virtual TravelOrder TravelOrder { get; set; }
    }
}
