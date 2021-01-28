using Microsoft.EntityFrameworkCore.Migrations;

namespace AspnetCoreCrudApp.Migrations
{
    public partial class categoryUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryDate",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryDate",
                table: "Category");
        }
    }
}
