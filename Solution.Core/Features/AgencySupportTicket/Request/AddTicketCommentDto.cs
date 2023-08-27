using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Core.Features.AgencySupportTicket.Request
{
    public class AddTicketCommentDto
    {
        public int? SupportTicketId { get; set; }
        public int SuperAdminLoginId { get; set; }
        public string Content { get; set; } = string.Empty;
    }
}
