using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace clean.Data.Migrations
{
    public partial class changeCustomerName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "customer",
                newName: "name"
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "customer",
                newName: "Name"
                );
        }
    }
}
