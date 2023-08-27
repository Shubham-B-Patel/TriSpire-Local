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
    public class GetAgencyTicketListQuery : IRequest<List<ReturnAgencyTicketDto>>
    {
        public int OrganizationId { get; set; }
    }

    public class GetAgencyTicketListHandler : IRequestHandler<GetAgencyTicketListQuery, List<ReturnAgencyTicketDto>>
    {
        private readonly IAgencySupportTicketService _agencySupportTicketService;

        public GetAgencyTicketListHandler(IAgencySupportTicketService agencySupportTicketService)
        {
            _agencySupportTicketService = agencySupportTicketService;
        }

        public async Task<List<ReturnAgencyTicketDto>> Handle(GetAgencyTicketListQuery request, CancellationToken cancellationToken)
        {
            return _agencySupportTicketService.GetTicketListByOrganizationId(request.OrganizationId);
        }
    }
}
