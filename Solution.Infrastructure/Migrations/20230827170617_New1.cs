using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solution.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class New1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DocumentName",
                schema: "Support",
                table: "SupportTicketCommentDocument",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentName",
                schema: "Support",
                table: "SupportTicketCommentDocument");
        }
    }
}
