using Solution.Core.Features.AgencySupportTicket.Request;
using Solution.Core.Features.AgencySupportTicket.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Core.Common.Interfaces
{
    public interface IAgencySupportTicketService
    {
        Task<int> AddAgencySupportTicket(AddTicketDto addTicketDto);
        Task<int> AddSupportTicketDocument(int id , string Url, string name);
        List<ReturnAgencyTicketDto> GetTicketListByOrganizationId(int organizationId);
        Task<ReturnTicketDetailsDto> GetSupportTicketDetails(int SupportTicketId);
        Task<int> AddSupportTicketComment(AddTicketCommentDto addTicketCommentDto);
    }
}
