using Microsoft.EntityFrameworkCore;
using Solution.Core.Interfaces.Common;
using Solution.Domain.Entities.Organization;
using System.Reflection;

namespace Solution.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        // ==============  Organization =================//             


        public DbSet<SupportTicket> SupportTicket => Set<SupportTicket>();
        public DbSet<SupportTicketActivity> SupportTicketActivity => Set<SupportTicketActivity>();
        public DbSet<SupportTicketComments> SupportTicketComments => Set<SupportTicketComments>();
        public DbSet<SupportTicketDocument> SupportTicketDocument => Set<SupportTicketDocument>();
        public DbSet<SupportTicketCommentDocument> SupportTicketCommentDocument => Set<SupportTicketCommentDocument>();
        
    }
}

