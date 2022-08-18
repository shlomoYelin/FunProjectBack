using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FunProject.Persistence.Migrations
{
    public partial class Addphonenumbertocustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Customers");
        }
    }
}
