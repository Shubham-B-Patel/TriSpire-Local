using Solution.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Core.Features.AgencySupportTicket.ViewModels
{
    public class SupportTicketCommentDocumentVM : AuditableEntity
    { 
        public int SupportTicketCommentDocumentId { get; set; }
        public int? SupportTicketId { get; set; }
        public int? SupportTicketCommentsId { get; set; }
        public string DocumentName { get; set; }
        public string TicketCommentDocumentUrl { get; set; } = string.Empty;
    }
}
