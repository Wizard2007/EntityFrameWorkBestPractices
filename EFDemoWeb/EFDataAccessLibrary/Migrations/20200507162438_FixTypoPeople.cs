using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccessLibrary.Migrations
{
    public partial class FixTypoPeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Poeple_PersonId",
                table: "Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_EmailAdresses_Poeple_PersonId",
                table: "EmailAdresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Poeple",
                table: "Poeple");

            migrationBuilder.RenameTable(
                name: "Poeple",
                newName: "People");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_People_PersonId",
                table: "Adresses",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAdresses_People_PersonId",
                table: "EmailAdresses",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_People_PersonId",
                table: "Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_EmailAdresses_People_PersonId",
                table: "EmailAdresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "Poeple");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Poeple",
                table: "Poeple",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Poeple_PersonId",
                table: "Adresses",
                column: "PersonId",
                principalTable: "Poeple",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAdresses_Poeple_PersonId",
                table: "EmailAdresses",
                column: "PersonId",
                principalTable: "Poeple",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
