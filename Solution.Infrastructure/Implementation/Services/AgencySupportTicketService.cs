using Mapster;
using Solution.Core.Common.Interfaces;
using Solution.Core.Features.AgencySupportTicket.Request;
using Solution.Core.Features.AgencySupportTicket.Response;
using Solution.Core.Features.AgencySupportTicket.ViewModels;
using Solution.Domain.Entities.Organization;
using Solution.Infrastructure.Persistence;

namespace Solution.Infrastructure.Implementation.Services
{
    public class AgencySupportTicketService : IAgencySupportTicketService
    {
        private readonly ApplicationDbContext _context;

        public AgencySupportTicketService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddAgencySupportTicket(AddTicketDto addTicketDto)
        {
            try
            {

                Random random = new Random();
                var no = random.Next(1111111, 9999999);
                SupportTicketVM supportTicketVM = new SupportTicketVM()
                {
                    OrganizationId = addTicketDto.OrganizationId,
                    TicketNumber = "TN" + no,
                    Subject = addTicketDto.Subject,
                    CategoryId = addTicketDto.CategoryId,
                    PriorityId = addTicketDto.PriorityId,
                    StatusId = 1,
                    TypeId = addTicketDto.TypeId,
                    IsRead = false,
                    CreatedOn = DateTime.Now,
                };
                SupportTicket supportTicket = supportTicketVM.Adapt<SupportTicket>();
                await _context.SupportTicket.AddAsync(supportTicket);
                var res = await _context.SaveChangesAsync();
                if (res > 0)
                {
                    SupportTicketActivityVM activityVM = new SupportTicketActivityVM()
                    {
                        SupportTicketId = supportTicket.SupportTicketId,
                        Content = addTicketDto.Content,
                    };
                    SupportTicketActivity supportTicketActivity = activityVM.Adapt<SupportTicketActivity>();
                    await _context.SupportTicketActivity.AddAsync(supportTicketActivity);
                    await _context.SaveChangesAsync();

                    return supportTicket.SupportTicketId;
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<int> AddSupportTicketComment(AddTicketCommentDto addTicketCommentDto)
        {
            SupportTicketCommentsVM supportTicketCommentsVM = new SupportTicketCommentsVM()
            {
                SuperAdminLoginId = addTicketCommentDto.SuperAdminLoginId,
                SupportTicketId = addTicketCommentDto.SupportTicketId,
                Content = addTicketCommentDto.Content
            };
            SupportTicketComments supportTicketComments = supportTicketCommentsVM.Adapt<SupportTicketComments>();
            _context.SupportTicketComments.Add(supportTicketComments);
            var res = await _context.SaveChangesAsync();
            if(res > 0)
            {
                return supportTicketComments.SupportTicketCommentsId;
            }
            return 0;
        }

        public async Task<int> AddSupportTicketDocument(int id, string Url, string name)
        {
            try
            {
                SupportTicketDocumentVM supportTicketDocumentVM = new SupportTicketDocumentVM()
                {
                    SupportTicketId = id,
                    TicketDocumentUrl = Url,
                    DocumentName = name
                };
                SupportTicketDocument supportTicketDocument = supportTicketDocumentVM.Adapt<SupportTicketDocument>();
                await _context.SupportTicketDocument.AddAsync(supportTicketDocument);
                await _context.SaveChangesAsync();
                return supportTicketDocument.SupportTicketDocumentId;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<ReturnTicketDetailsDto> GetSupportTicketDetails(int SupportTicketId)
        {
            /*var data = (from ticket in _context.SupportTicket
                        join ticketcontent
                        in _context.SupportTicketActivity on
                        ticket.SupportTicketId equals ticketcontent.SupportTicketId
                        where ticket.SupportTicketId == SupportTicketId
                        orderby ticket.CreatedOn descending
                        select new ReturnAgencyTicketDto()
                        {
                            SupportTicketId = ticket.SupportTicketId,
                            OrganizationId = ticket.OrganizationId,
                            TicketNumber = ticket.TicketNumber,
                            Subject = ticket.Subject,
                            CategoryId = ticket.CategoryId,
                            PriorityId = ticket.PriorityId,
                            StatusId = ticket.StatusId,
                            TypeId = ticket.TypeId,
                            IsRead = ticket.IsRead,
                            CreatedOn = ticket.CreatedOn,
                            SupportTicketActivityId = ticketcontent.SupportTicketActivityId,
                            Content = ticketcontent.Content
                        });*/
            var ticket = _context.SupportTicket.FirstOrDefault(x => x.SupportTicketId == SupportTicketId);
            var ticketcontent = _context.SupportTicketActivity.FirstOrDefault(x => x.SupportTicketId == SupportTicketId);

            ReturnAgencyTicketDto data = new ReturnAgencyTicketDto()
            {
                SupportTicketId = ticket.SupportTicketId,
                OrganizationId = ticket.OrganizationId,
                TicketNumber = ticket.TicketNumber,
                Subject = ticket.Subject,
                CategoryId = ticket.CategoryId,
                PriorityId = ticket.PriorityId,
                StatusId = ticket.StatusId,
                TypeId = ticket.TypeId,
                IsRead = ticket.IsRead,
                CreatedOn = ticket.CreatedOn,
                SupportTicketActivityId = ticketcontent.SupportTicketActivityId,
                Content = ticketcontent.Content
            };

            var tcktdoc = _context.SupportTicketDocument.Where(x => x.SupportTicketId == SupportTicketId).ToList();
            List<SupportTicketDocument> supportTicketDocuments = new List<SupportTicketDocument>();
            foreach (var doc in tcktdoc)
            {
                supportTicketDocuments.Add(doc);
            }

            var tcktcomments = _context.SupportTicketComments.Where(x => x.SupportTicketId == SupportTicketId).ToList();
            List<ReturnCommentDetailsDto> returnCommentDetailsDto = new List<ReturnCommentDetailsDto>();
            foreach (var comment in tcktcomments)
            {
                var doc = _context.SupportTicketCommentDocument.Where(x => x.SupportTicketCommentsId == comment.SupportTicketCommentsId).ToList();
                ReturnCommentDetailsDto returnComment = new ReturnCommentDetailsDto()
                {
                    SupportTicketComments = comment,
                    SupportTicketCommentsDocuments = doc
                };
                returnCommentDetailsDto.Add(returnComment);
            }

            ReturnTicketDetailsDto returnTicketDetailsDto = new ReturnTicketDetailsDto()
            {
                ReturnAgencyTicket = data,
                SupportTicketDocuments = supportTicketDocuments,
                ReturnCommentDocuments = returnCommentDetailsDto
            };

            return returnTicketDetailsDto;
        }

        public List<ReturnAgencyTicketDto> GetTicketListByOrganizationId(int organizationId)
        {
            var data = (from ticket in _context.SupportTicket
                        join ticketcontent
                        in _context.SupportTicketActivity on
                        ticket.SupportTicketId equals ticketcontent.SupportTicketId
                        where ticket.IsDeleted == false && ticket.OrganizationId == organizationId
                        orderby ticket.CreatedOn descending
                        select new ReturnAgencyTicketDto()
                        {
                            SupportTicketId = ticket.SupportTicketId,
                            OrganizationId = ticket.OrganizationId,
                            TicketNumber = ticket.TicketNumber,
                            Subject = ticket.Subject,
                            CategoryId = ticket.CategoryId,
                            PriorityId = ticket.PriorityId,
                            StatusId = ticket.StatusId,
                            TypeId = ticket.TypeId,
                            IsRead = ticket.IsRead,
                            CreatedOn = ticket.CreatedOn,
                            SupportTicketActivityId = ticketcontent.SupportTicketActivityId,
                            Content = ticketcontent.Content
                        }).ToList();
            return data;
        }
    }
}