using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Solution.Domain.Entities.Organization;

namespace Solution.Infrastructure.Persistence.Configurations.Organization
{
    public class SupportTicketCommentsConfig : IEntityTypeConfiguration<SupportTicketComments>
    {
        public void Configure(EntityTypeBuilder<SupportTicketComments> builder)
        {
            /* Table and primary key configuration */
            builder.ToTable(name: "SupportTicketComments", schema: "Support").HasKey(pk => pk.SupportTicketCommentsId);
            builder.ToTable(name: "SupportTicketComments", schema: "Support").Property(pk => pk.SupportTicketCommentsId).HasColumnName("SupportTicketCommentsId").UseIdentityColumn();

            /* Table columns configuration */

            builder.Property(p => p.SupportTicketCommentsId).HasColumnName("SupportTicketCommentsId");
            builder.Property(p => p.SupportTicketId).HasColumnName("SupportTicketId");
            builder.Property(p => p.Content).HasColumnName("Content");
           
        }
    }
}