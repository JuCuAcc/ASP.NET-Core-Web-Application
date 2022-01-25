using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Book.Data.Migrations
{
    public partial class LibrarianExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Librarians_LibrarianID",
                table: "Experiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Librarians",
                table: "Librarians");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Librarians");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Librarians");

            migrationBuilder.DropColumn(
                name: "ApplicantId",
                table: "Experiences");

            migrationBuilder.RenameColumn(
                name: "LibrarianID",
                table: "Experiences",
                newName: "LibrarianId");

            migrationBuilder.RenameIndex(
                name: "IX_Experiences_LibrarianID",
                table: "Experiences",
                newName: "IX_Experiences_LibrarianId");

            migrationBuilder.AddColumn<int>(
                name: "LibrarianId",
                table: "Librarians",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "Librarians",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "Librarians",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Librarians",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Librarians",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "HasInsurance",
                table: "Librarians",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "JoiningDate",
                table: "Librarians",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Librarians",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Librarians",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PinCode",
                table: "Librarians",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Salary",
                table: "Librarians",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<DateTime>(
                name: "ShiftTime",
                table: "Librarians",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "LibrarianId",
                table: "Experiences",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Librarians",
                table: "Librarians",
                column: "LibrarianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Librarians_LibrarianId",
                table: "Experiences",
                column: "LibrarianId",
                principalTable: "Librarians",
                principalColumn: "LibrarianId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Librarians_LibrarianId",
                table: "Experiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Librarians",
                table: "Librarians");

            migrationBuilder.DropColumn(
                name: "LibrarianId",
                table: "Librarians");

            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "Librarians");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "Librarians");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Librarians");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Librarians");

            migrationBuilder.DropColumn(
                name: "HasInsurance",
                table: "Librarians");

            migrationBuilder.DropColumn(
                name: "JoiningDate",
                table: "Librarians");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Librarians");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Librarians");

            migrationBuilder.DropColumn(
                name: "PinCode",
                table: "Librarians");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Librarians");

            migrationBuilder.DropColumn(
                name: "ShiftTime",
                table: "Librarians");

            migrationBuilder.RenameColumn(
                name: "LibrarianId",
                table: "Experiences",
                newName: "LibrarianID");

            migrationBuilder.RenameIndex(
                name: "IX_Experiences_LibrarianId",
                table: "Experiences",
                newName: "IX_Experiences_LibrarianID");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Librarians",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Librarians",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "LibrarianID",
                table: "Experiences",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ApplicantId",
                table: "Experiences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Librarians",
                table: "Librarians",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Librarians_LibrarianID",
                table: "Experiences",
                column: "LibrarianID",
                principalTable: "Librarians",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
