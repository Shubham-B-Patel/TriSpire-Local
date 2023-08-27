using Solution.Core.Features.AgencySupportTicket.Request;
using Solution.Core.Features.AgencySupportTicket.Response;

namespace Solution.Core.Common.Interfaces
{
    public interface IAgencySupportTicketService
    {
        Task<int> AddAgencySupportTicket(AddTicketDto addTicketDto);
        Task<int> AddSupportTicketDocument(int id, string Url, string name);
        List<ReturnAgencyTicketDto> GetTicketListByOrganizationId(int organizationId);
        Task<ReturnTicketDetailsDto> GetSupportTicketDetails(int SupportTicketId);
        Task<int> AddSupportTicketComment(AddTicketCommentDto addTicketCommentDto);
    }
}
