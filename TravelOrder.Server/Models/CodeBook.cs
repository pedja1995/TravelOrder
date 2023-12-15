namespace TravelOrder.Server.Models
{
    public static class CodeBook
    {
        public enum ApprovalProcessStatus
        {
            OnHold = 0,
            Aproved = 1,
            Denied = 2
        }

        public enum ApprovalProcessAction
        {
            Reject = 0,
            Accept = 1
        }
    }
}
