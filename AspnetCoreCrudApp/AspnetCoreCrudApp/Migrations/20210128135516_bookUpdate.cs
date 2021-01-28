using Microsoft.EntityFrameworkCore.Migrations;

namespace AspnetCoreCrudApp.Migrations
{
    public partial class bookUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookLang",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookLang",
                table: "Book");
        }
    }
}
