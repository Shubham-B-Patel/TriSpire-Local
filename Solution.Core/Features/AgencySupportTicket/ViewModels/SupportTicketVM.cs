using Solution.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Core.Features.AgencySupportTicket.ViewModels
{
    public class SupportTicketVM : AuditableEntity
    {
        public int SupportTicketId { get; set; }
        public int? OrganizationId { get; set; }
        public string? TicketNumber { get; set; }
        public string Subject { get; set; } = string.Empty;
        public int? CategoryId { get; set; }
        public int? PriorityId { get; set; }
        public int? StatusId { get; set; }
        public int? TypeId { get; set; }
        public bool IsRead { get; set; }
    }
}
