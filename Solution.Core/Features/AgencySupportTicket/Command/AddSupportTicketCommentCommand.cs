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
    public class AddSupportTicketCommentCommand : IRequest<int>
    {
        public AddTicketCommentDto AddTicketCommentDto { get; set; }
    }

    public class AddSupportTicketCommentHandler : IRequestHandler<AddSupportTicketCommentCommand, int>
    {
        private readonly IAgencySupportTicketService _agencySupportTicketService;

        public AddSupportTicketCommentHandler(IAgencySupportTicketService agencySupportTicketService)
        {
            _agencySupportTicketService = agencySupportTicketService;
        }

        public async Task<int> Handle(AddSupportTicketCommentCommand request, CancellationToken cancellationToken)
        {
            return await _agencySupportTicketService.AddSupportTicketComment(request.AddTicketCommentDto);
        }
    }
}
