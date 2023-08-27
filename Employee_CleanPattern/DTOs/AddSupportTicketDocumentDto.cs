namespace Employee_CleanPattern.DTOs
{
    public class AddSupportTicketDocumentDto
    {
        public int SupportTicketId { get; set; }   
        public IFormFile[] Files { get; set; }
    }
}
