using Microsoft.EntityFrameworkCore;
using Solution.Domain.Entities.Organization;

namespace Solution.Core.Interfaces.Common
{
    public interface IApplicationDbContext
    {
        DbSet<SupportTicket> SupportTicket { get; }
        DbSet<SupportTicketActivity> SupportTicketActivity { get; }
        DbSet<SupportTicketComments> SupportTicketComments { get; }
        DbSet<SupportTicketDocument> SupportTicketDocument { get; }
        DbSet<SupportTicketCommentDocument> SupportTicketCommentDocument { get; }

        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
