using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FunProject.Persistence.Migrations
{
    public partial class addingQuantitytoproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");
        }
    }
}
