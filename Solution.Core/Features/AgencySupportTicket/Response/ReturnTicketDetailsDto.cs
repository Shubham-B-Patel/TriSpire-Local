using Solution.Domain.Entities.Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Core.Features.AgencySupportTicket.Response
{
    public class ReturnTicketDetailsDto
    {
        public ReturnAgencyTicketDto ReturnAgencyTicket { get; set; }
        public List<SupportTicketDocument> SupportTicketDocuments { get; set; }
        public List<ReturnCommentDetailsDto> ReturnCommentDocuments { get; set; } = new List<ReturnCommentDetailsDto>();
    }
}
