using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Core.Features.AgencySupportTicket.Request
{
    public class AddTicketDto
    {
        public int? OrganizationId { get; set; }
        public string Subject { get; set; } = string.Empty;
        public int? CategoryId { get; set; }
        public int? PriorityId { get; set; }
        public int? TypeId { get; set; }
        public string Content { get; set; } = string.Empty;
    }
}
