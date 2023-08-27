using MediatR;
using Solution.Core.Common.Interfaces;

namespace Solution.Core.Features.AgencySupportTicket.Command
{
    public class AddSupportTicketDocumentCommand : IRequest<int>
    {
        public int SupportTicketId { get; set; }
        public string DocumentUrl { get; set; }
        public string DocumentName { get; set; }
    }

    public class AddSupportTicketDocumentHandler : IRequestHandler<AddSupportTicketDocumentCommand, int>
    {
        private readonly IAgencySupportTicketService _agencySupportTicketService;

        public AddSupportTicketDocumentHandler(IAgencySupportTicketService agencySupportTicketService)
        {
            _agencySupportTicketService = agencySupportTicketService;
        }

        public Task<int> Handle(AddSupportTicketDocumentCommand request, CancellationToken cancellationToken)
        {
            var res = _agencySupportTicketService.AddSupportTicketDocument(request.SupportTicketId, request.DocumentUrl, request.DocumentName);
            return res;
        }
    }
}
