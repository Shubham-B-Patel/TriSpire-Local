using Solution.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities.Organization
{
    public class SupportTicketDocument : AuditableEntity
    {
        public int SupportTicketDocumentId { get; set; }
        public int? SupportTicketId { get; set; }
        public string DocumentName { get; set; }
        public string TicketDocumentUrl { get; set; } = string.Empty;        
    }
}
