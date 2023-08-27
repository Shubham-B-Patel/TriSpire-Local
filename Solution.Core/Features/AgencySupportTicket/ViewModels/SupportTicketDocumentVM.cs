using Solution.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Core.Features.AgencySupportTicket.ViewModels
{
    public class SupportTicketDocumentVM : AuditableEntity
    {
        public int SupportTicketDocumentId { get; set; }
        public int? SupportTicketId { get; set; }
        public string DocumentName { get; set; }
        public string TicketDocumentUrl { get; set; } = string.Empty;
    }
}
