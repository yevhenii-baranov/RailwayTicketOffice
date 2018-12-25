using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RailwayTicketOffice.Migrations
{
    public partial class trips3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserRole",
                table: "user",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainID",
                table: "trip",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "TripDate",
                table: "trip",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_trip_TrainID",
                table: "trip",
                column: "TrainID");

            migrationBuilder.AddForeignKey(
                name: "FK_trip_train_TrainID",
                table: "trip",
                column: "TrainID",
                principalTable: "train",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trip_train_TrainID",
                table: "trip");

            migrationBuilder.DropIndex(
                name: "IX_trip_TrainID",
                table: "trip");

            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "user");

            migrationBuilder.DropColumn(
                name: "TrainID",
                table: "trip");

            migrationBuilder.DropColumn(
                name: "TripDate",
                table: "trip");
        }
    }
}
