﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Solution.Infrastructure.Persistence;

#nullable disable

namespace Solution.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230826142604_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Solution.Domain.Entities.Organization.SupportTicket", b =>
                {
                    b.Property<int>("SupportTicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SupportTicketId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupportTicketId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryId");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("CreatedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<string>("DeletedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit")
                        .HasColumnName("IsRead");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("int")
                        .HasColumnName("OrganizationId");

                    b.Property<int?>("PriorityId")
                        .HasColumnType("int")
                        .HasColumnName("PriorityId");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("StatusId");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Subject");

                    b.Property<string>("TicketNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("TicketNumber");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int")
                        .HasColumnName("TypeId");

                    b.HasKey("SupportTicketId");

                    b.ToTable("SupportTicket", "Support");
                });

            modelBuilder.Entity("Solution.Domain.Entities.Organization.SupportTicketActivity", b =>
                {
                    b.Property<int>("SupportTicketActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SupportTicketActivityId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupportTicketActivityId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Content");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("CreatedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<string>("DeletedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SupportTicketId")
                        .HasColumnType("int")
                        .HasColumnName("SupportTicketId");

                    b.HasKey("SupportTicketActivityId");

                    b.ToTable("SupportTicketActivity", "Support");
                });

            modelBuilder.Entity("Solution.Domain.Entities.Organization.SupportTicketCommentDocument", b =>
                {
                    b.Property<int>("SupportTicketCommentDocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SupportTicketCommentDocumentId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupportTicketCommentDocumentId"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("CreatedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<string>("DeletedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SupportTicketCommentsId")
                        .HasColumnType("int")
                        .HasColumnName("SupportTicketCommentsId");

                    b.Property<int?>("SupportTicketId")
                        .HasColumnType("int")
                        .HasColumnName("SupportTicketId");

                    b.Property<string>("TicketCommentDocumentUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TicketCommentDocumentUrl");

                    b.HasKey("SupportTicketCommentDocumentId");

                    b.ToTable("SupportTicketCommentDocument", "Support");
                });

            modelBuilder.Entity("Solution.Domain.Entities.Organization.SupportTicketComments", b =>
                {
                    b.Property<int>("SupportTicketCommentsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SupportTicketCommentsId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupportTicketCommentsId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Content");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("CreatedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<string>("DeletedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("SuperAdminLoginId")
                        .HasColumnType("int");

                    b.Property<int?>("SupportTicketId")
                        .HasColumnType("int")
                        .HasColumnName("SupportTicketId");

                    b.HasKey("SupportTicketCommentsId");

                    b.ToTable("SupportTicketComments", "Support");
                });

            modelBuilder.Entity("Solution.Domain.Entities.Organization.SupportTicketDocument", b =>
                {
                    b.Property<int>("SupportTicketDocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SupportTicketDocumentId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupportTicketDocumentId"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("CreatedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<string>("DeletedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SupportTicketId")
                        .HasColumnType("int")
                        .HasColumnName("SupportTicketId");

                    b.Property<string>("TicketDocumentUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TicketDocumentUrl");

                    b.HasKey("SupportTicketDocumentId");

                    b.ToTable("SupportTicketDocument", "Support");
                });
#pragma warning restore 612, 618
        }
    }
}
