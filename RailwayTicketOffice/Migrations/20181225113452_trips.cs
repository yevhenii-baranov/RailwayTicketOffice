using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RailwayTicketOffice.Migrations
{
    public partial class trips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartureDate",
                table: "train");

            migrationBuilder.AlterColumn<long>(
                name: "ArrivalTime",
                table: "train",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<long>(
                name: "DepartureTime",
                table: "train",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartureTime",
                table: "train");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ArrivalTime",
                table: "train",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<DateTime>(
                name: "DepartureDate",
                table: "train",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
