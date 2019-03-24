using Microsoft.EntityFrameworkCore.Migrations;

namespace RailwayTicketOffice.Migrations
{
    public partial class trainid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trip_train_TrainID",
                table: "trip");

            migrationBuilder.RenameColumn(
                name: "TrainID",
                table: "trip",
                newName: "TrainId");

            migrationBuilder.RenameIndex(
                name: "IX_trip_TrainID",
                table: "trip",
                newName: "IX_trip_TrainId");

            migrationBuilder.AddForeignKey(
                name: "FK_trip_train_TrainId",
                table: "trip",
                column: "TrainId",
                principalTable: "train",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trip_train_TrainId",
                table: "trip");

            migrationBuilder.RenameColumn(
                name: "TrainId",
                table: "trip",
                newName: "TrainID");

            migrationBuilder.RenameIndex(
                name: "IX_trip_TrainId",
                table: "trip",
                newName: "IX_trip_TrainID");

            migrationBuilder.AddForeignKey(
                name: "FK_trip_train_TrainID",
                table: "trip",
                column: "TrainID",
                principalTable: "train",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
