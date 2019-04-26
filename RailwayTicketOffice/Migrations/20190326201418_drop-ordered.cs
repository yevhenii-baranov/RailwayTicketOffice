using Microsoft.EntityFrameworkCore.Migrations;

namespace RailwayTicketOffice.Migrations
{
    public partial class dropordered : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ordered",
                table: "seat");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "Ordered",
                table: "seat",
                type: "bit",
                nullable: false,
                defaultValue: (short)0);
        }
    }
}
