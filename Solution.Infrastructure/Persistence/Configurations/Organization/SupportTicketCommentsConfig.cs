using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Solution.Domain.Entities.Organization;

namespace Solution.Infrastructure.Persistence.Configurations.Organization
{
    public class SupportTicketDocumentConfig : IEntityTypeConfiguration<SupportTicketDocument>
    {
        public void Configure(EntityTypeBuilder<SupportTicketDocument> builder)
        {
            /* Table and primary key configuration */
            builder.ToTable(name: "SupportTicketDocument", schema: "Support").HasKey(pk => pk.SupportTicketDocumentId);
            builder.ToTable(name: "SupportTicketDocument", schema: "Support").Property(pk => pk.SupportTicketDocumentId).HasColumnName("SupportTicketDocumentId").UseIdentityColumn();

            /* Table columns configuration */

            builder.Property(p => p.SupportTicketDocumentId).HasColumnName("SupportTicketDocumentId");
            builder.Property(p => p.SupportTicketId).HasColumnName("SupportTicketId");
            builder.Property(p => p.TicketDocumentUrl).HasColumnName("TicketDocumentUrl");           
        }
    }
}