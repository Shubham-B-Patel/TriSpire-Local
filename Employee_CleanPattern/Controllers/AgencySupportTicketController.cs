
using Employee_CleanPattern.DTOs;
using Employee_CleanPattern.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Solution.Core.Features.AgencySupportTicket.Command;
using Solution.Core.Features.AgencySupportTicket.Queries;
using Solution.Core.Features.AgencySupportTicket.Request;

namespace Employee_CleanPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgencySupportTicketController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AgencySupportTicketController(IMediator mediator, IWebHostEnvironment webHostEnvironment)
        {
            _mediator = mediator;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddAgencySupportTicket(AddTicketDto addTicketDto)
        {
            var res = await _mediator.Send(new CreateAgencySupportTicketCommand() { AddTicketDto = addTicketDto });
            if (res == 0)
            {
                return BadRequest(new
                {
                    message = "Failed"
                });
            }
            return Ok(new
            {
                message = "Success",
                support_TicketId = res
            });
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddAgencySupportTicketDocument([FromForm] AddSupportTicketDocumentDto data)
        {
            foreach (var file in data.Files)
            {
                AddSupportTicketDocumentService obj = new AddSupportTicketDocumentService(_webHostEnvironment, _mediator);
                obj.UploadDocuments(data.SupportTicketId, file);
            }
            return Ok(new
            {
                message = "Success"
            });
        }

        [HttpGet("[action]/{OrganizationId}")]
        public async Task<IActionResult> GetAgencyTicketList(int OrganizationId)
        {
            var data = _mediator.Send(new GetAgencyTicketListQuery()
            {
                OrganizationId = OrganizationId
            });
            return Ok(data.Result);
        }

        [HttpGet("[action]/{SupportTicketId}")]
        public async Task<IActionResult> GetSupportTicketDetails(int SupportTicketId)
        {
            var data = _mediator.Send(new GetSupportTicketDetailsQuery()
            {
                SupportTicketId = SupportTicketId
            });
            return Ok(data.Result);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddSupportTicketComment(AddTicketCommentDto addTicketCommentDto)
        {
            var res = await _mediator.Send(new AddSupportTicketCommentCommand()
            {
                AddTicketCommentDto = addTicketCommentDto
            });
            if (res > 0)
            {
                return Ok(new
                {
                    message = "Success",
                    id = res
                });
            }
            return Ok(new
            {
                message = "Failed"
            });
        }
    }
}
