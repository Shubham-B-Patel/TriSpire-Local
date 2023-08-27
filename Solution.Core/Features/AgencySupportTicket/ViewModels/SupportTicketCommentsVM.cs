using Solution.Domain.Common;

namespace Solution.Core.Features.AgencySupportTicket.ViewModels
{
    public class SupportTicketCommentsVM : AuditableEntity
    {
        public int SupportTicketCommentsId { get; set; }
        public int? SupportTicketId { get; set; }
        public int SuperAdminLoginId { get; set; }
        public string Content { get; set; } = string.Empty;
    }
}
