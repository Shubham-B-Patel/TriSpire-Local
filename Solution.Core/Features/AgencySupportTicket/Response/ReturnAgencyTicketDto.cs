namespace Solution.Core.Features.AgencySupportTicket.Response
{
    public class ReturnAgencyTicketDto
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
        public DateTime CreatedOn { get; set; }
        public int SupportTicketActivityId { get; set; }
        public string Content { get; set; } = string.Empty;
    }
}
