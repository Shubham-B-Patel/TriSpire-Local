using MediatR;
using Solution.Core.Common.Interfaces;
using Solution.Core.Features.AgencySupportTicket.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Core.Features.AgencySupportTicket.Command
{
    public class CreateAgencySupportTicketCommand : IRequest<int>
    {
        public AddTicketDto AddTicketDto { get; set; }
    }

    public class AddAgencySupportTicketHandler : IRequestHandler<CreateAgencySupportTicketCommand, int>
    {
        private readonly IAgencySupportTicketService _agencySupportTicketService;

        public AddAgencySupportTicketHandler(IAgencySupportTicketService agencySupportTicketService)
        {
            _agencySupportTicketService = agencySupportTicketService;
        }

        public Task<int> Handle(CreateAgencySupportTicketCommand request, CancellationToken cancellationToken)
        {
            return _agencySupportTicketService.AddAgencySupportTicket(request.AddTicketDto);
        }
    }
}
