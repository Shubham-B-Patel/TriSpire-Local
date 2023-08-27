using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Solution.Domain.Entities.Organization;

namespace Solution.Infrastructure.Persistence.Configurations.Organization
{
    public class SupportTicketActivityConfig : IEntityTypeConfiguration<SupportTicketActivity>
    {
        public void Configure(EntityTypeBuilder<SupportTicketActivity> builder)
        {
            /* Table and primary key configuration */
            builder.ToTable(name: "SupportTicketActivity", schema: "Support").HasKey(pk => pk.SupportTicketActivityId);
            builder.ToTable(name: "SupportTicketActivity", schema: "Support").Property(pk => pk.SupportTicketActivityId).HasColumnName("SupportTicketActivityId").UseIdentityColumn();

            /* Table columns configuration */

            builder.Property(p => p.SupportTicketActivityId).HasColumnName("SupportTicketActivityId");
            builder.Property(p => p.SupportTicketId).HasColumnName("SupportTicketId");
            builder.Property(p => p.Content).HasColumnName("Content");
           
        }
    }
}