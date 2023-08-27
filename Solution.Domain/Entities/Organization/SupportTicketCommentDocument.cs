using Solution.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities.Organization
{
    public class SupportTicketCommentDocument : AuditableEntity
    {
        public int SupportTicketCommentDocumentId { get; set; }
        public int? SupportTicketId { get; set; }
        public int? SupportTicketCommentsId { get; set; }
        public string DocumentName { get; set; }
        public string TicketCommentDocumentUrl { get; set; } = string.Empty;        
    }
}
