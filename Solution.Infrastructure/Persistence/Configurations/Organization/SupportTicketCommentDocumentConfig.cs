using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Solution.Domain.Entities.Organization;

namespace Solution.Infrastructure.Persistence.Configurations.Organization
{
    public class SupportTicketCommentDocumentConfig : IEntityTypeConfiguration<SupportTicketCommentDocument>
    {
        public void Configure(EntityTypeBuilder<SupportTicketCommentDocument> builder)
        {
            /* Table and primary key configuration */
            builder.ToTable(name: "SupportTicketCommentDocument", schema: "Support").HasKey(pk => pk.SupportTicketCommentDocumentId);
            builder.ToTable(name: "SupportTicketCommentDocument", schema: "Support").Property(pk => pk.SupportTicketCommentDocumentId).HasColumnName("SupportTicketCommentDocumentId").UseIdentityColumn();

            /* Table columns configuration */

            builder.Property(p => p.SupportTicketCommentDocumentId).HasColumnName("SupportTicketCommentDocumentId");
            builder.Property(p => p.SupportTicketId).HasColumnName("SupportTicketId");
            builder.Property(p => p.SupportTicketCommentsId).HasColumnName("SupportTicketCommentsId");
            builder.Property(p => p.TicketCommentDocumentUrl).HasColumnName("TicketCommentDocumentUrl");
           
        }
    }
}