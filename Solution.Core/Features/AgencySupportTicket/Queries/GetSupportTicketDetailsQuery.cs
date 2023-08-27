using MediatR;
using Solution.Core.Common.Interfaces;
using Solution.Core.Features.AgencySupportTicket.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Core.Features.AgencySupportTicket.Queries
{
    public class GetSupportTicketDetailsQuery : IRequest<ReturnTicketDetailsDto>
    {
        public int SupportTicketId { get; set; }
    }

    public class GetSupportTicketDetailsHandler : IRequestHandler<GetSupportTicketDetailsQuery, ReturnTicketDetailsDto>
    {
        private readonly IAgencySupportTicketService _agencySupportTicketService;

        public GetSupportTicketDetailsHandler(IAgencySupportTicketService agencySupportTicketService)
        {
            _agencySupportTicketService = agencySupportTicketService;
        }

        public Task<ReturnTicketDetailsDto> Handle(GetSupportTicketDetailsQuery request, CancellationToken cancellationToken)
        {
            return _agencySupportTicketService.GetSupportTicketDetails(request.SupportTicketId);
        }
    }
}
