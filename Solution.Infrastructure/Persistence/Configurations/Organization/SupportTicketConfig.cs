using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Solution.Domain.Entities.Organization;

namespace Solution.Infrastructure.Persistence.Configurations.Organization
{
    public class SupportTicketConfig : IEntityTypeConfiguration<SupportTicket>
    {
        public void Configure(EntityTypeBuilder<SupportTicket> builder)
        {
            /* Table and primary key configuration */
            builder.ToTable(name: "SupportTicket", schema: "Support").HasKey(pk => pk.SupportTicketId);
            builder.ToTable(name: "SupportTicket", schema: "Support").Property(pk => pk.SupportTicketId).HasColumnName("SupportTicketId").UseIdentityColumn();

            /* Table columns configuration */

            builder.Property(p => p.SupportTicketId).HasColumnName("SupportTicketId");
            builder.Property(p => p.OrganizationId).HasColumnName("OrganizationId");
            builder.Property(p => p.TicketNumber).HasColumnName("TicketNumber").HasMaxLength(20);
            builder.Property(p => p.Subject).HasColumnName("Subject").HasMaxLength(200);
            builder.Property(p => p.CategoryId).HasColumnName("CategoryId");
            builder.Property(p => p.PriorityId).HasColumnName("PriorityId");
            builder.Property(p => p.StatusId).HasColumnName("StatusId");
            builder.Property(p => p.TypeId).HasColumnName("TypeId");
            builder.Property(p => p.IsRead).HasColumnName("IsRead");
        }
    }
}