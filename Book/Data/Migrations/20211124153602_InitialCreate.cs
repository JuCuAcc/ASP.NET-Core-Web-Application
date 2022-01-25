using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Book.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    Edition = table.Column<int>(maxLength: 100, nullable: false),
                    PublishingDate = table.Column<DateTime>(nullable: false),
                    PublishingTime = table.Column<DateTime>(nullable: false),
                    Venue = table.Column<string>(maxLength: 255, nullable: false),
                    BookPicture = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
