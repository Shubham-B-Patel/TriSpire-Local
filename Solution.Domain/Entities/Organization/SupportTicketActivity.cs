using Solution.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Domain.Entities.Organization
{
    public class SupportTicketActivity : AuditableEntity
    {
        public int SupportTicketActivityId { get; set; }
        public int? SupportTicketId { get; set; }      
        public string Content { get; set; } = string.Empty;      
       
    }
}
