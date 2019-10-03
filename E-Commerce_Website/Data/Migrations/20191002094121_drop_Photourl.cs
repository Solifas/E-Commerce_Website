using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce_Website.Data.Migrations
{
    public partial class drop_Photourl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductImageUrl",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductImageUrl",
                table: "Products",
                nullable: true);
        }
    }
}
