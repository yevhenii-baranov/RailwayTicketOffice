using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RailwayTicketOffice.Migrations
{
    public partial class addpurchasedate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "ticket",
                newName: "TripDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseDate",
                table: "ticket",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "ticket");

            migrationBuilder.RenameColumn(
                name: "TripDate",
                table: "ticket",
                newName: "Date");
        }
    }
}
