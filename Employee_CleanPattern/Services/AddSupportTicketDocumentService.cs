using MediatR;
using Solution.Core.Features.AgencySupportTicket.Command;

namespace Employee_CleanPattern.Services
{
    public class AddSupportTicketDocumentService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMediator _mediator;

        public AddSupportTicketDocumentService(IWebHostEnvironment webHostEnvironment, IMediator mediator)
        {
            _webHostEnvironment = webHostEnvironment;
            _mediator = mediator;
        }

        public void UploadDocuments(int Id, IFormFile file)
        {
            var contentPath = this._webHostEnvironment.WebRootPath;
            var path = Path.Combine(contentPath, "AgencySupportTicket/Documents");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var ext = Path.GetExtension(file.FileName);
            var newName = DateTime.Now.Ticks.ToString();
            var newFileName = Id + newName + ext;
            var fileWithPath = Path.Combine(path, newFileName);
            var stream = new FileStream(fileWithPath, FileMode.Create);
            file.CopyTo(stream);
            stream.Close();

            var newPath = "https://localhost:7071/" + "/AgencySupportTicket/Documents/" + newFileName;

            _mediator.Send(new AddSupportTicketDocumentCommand() { SupportTicketId = Id, DocumentUrl = newPath, DocumentName = newFileName });
        }
    }
}