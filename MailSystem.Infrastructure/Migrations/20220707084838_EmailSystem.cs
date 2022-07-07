using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MailSystem.Infrastructure.Data.Migrations
{
    public partial class EmailSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "es");

            migrationBuilder.CreateTable(
                name: "emails",
                schema: "es",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    To = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    From = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: false),
                    Cc = table.Column<string>(type: "nvarchar(320)", maxLength: 320, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(72)", maxLength: 72, nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsHtml = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_email", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "emails",
                schema: "es");
        }
    }
}
