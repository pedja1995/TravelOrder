using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelOrder.Server.Models
{
    public class ApprovalProcess
    {
        [Key]
        [ForeignKey(nameof(TravelOrder))]
        public int TravelOrderId { get; set; }

        public short ApprovalProcessStatus { get; set; } = (short)CodeBook.ApprovalProcessStatus.OnHold;

        public DateTime? DecisionDate { get; set; }

        [MaxLength(150)]
        public string Note { get; set; } = string.Empty;

        public virtual TravelOrder TravelOrder { get; set; }
    }
}
