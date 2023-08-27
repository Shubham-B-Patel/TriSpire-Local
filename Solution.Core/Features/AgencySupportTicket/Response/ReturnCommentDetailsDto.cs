using Solution.Domain.Entities.Organization;

namespace Solution.Core.Features.AgencySupportTicket.Response
{
    public class ReturnCommentDetailsDto
    {
        public SupportTicketComments SupportTicketComments { get; set; } = new SupportTicketComments();
        public List<SupportTicketCommentDocument> SupportTicketCommentsDocuments { get; set; } = new List<SupportTicketCommentDocument>();
    }
}
