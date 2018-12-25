using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RailwayTicketOffice.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carriage",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CarriageType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carriage", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "station",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_station", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    PassportData = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "seat",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    NumberInCarriage = table.Column<int>(nullable: false),
                    Ordered = table.Column<short>(type: "bit", nullable: false, defaultValue: (short)0),
                    CarriageID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_seat_carriage_CarriageID",
                        column: x => x.CarriageID,
                        principalTable: "carriage",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "train",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    DepartureDate = table.Column<DateTime>(nullable: false),
                    ArrivalTime = table.Column<DateTime>(nullable: false),
                    DepartureStationID = table.Column<int>(nullable: false),
                    ArrivalStationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_train", x => x.ID);
                    table.ForeignKey(
                        name: "FK_train_station_ArrivalStationID",
                        column: x => x.ArrivalStationID,
                        principalTable: "station",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_train_station_DepartureStationID",
                        column: x => x.DepartureStationID,
                        principalTable: "station",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ticket",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    PassengerID = table.Column<int>(nullable: false),
                    TrainID = table.Column<int>(nullable: false),
                    SeatID = table.Column<int>(nullable: false),
                    TicketType = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ticket_user_PassengerID",
                        column: x => x.PassengerID,
                        principalTable: "user",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_seat_SeatID",
                        column: x => x.SeatID,
                        principalTable: "seat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_train_TrainID",
                        column: x => x.TrainID,
                        principalTable: "train",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trainCarriage",
                columns: table => new
                {
                    TrainID = table.Column<int>(nullable: false),
                    CarriageID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainCarriage", x => new { x.CarriageID, x.TrainID });
                    table.ForeignKey(
                        name: "FK_trainCarriage_carriage_CarriageID",
                        column: x => x.CarriageID,
                        principalTable: "carriage",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_trainCarriage_train_TrainID",
                        column: x => x.TrainID,
                        principalTable: "train",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_seat_CarriageID",
                table: "seat",
                column: "CarriageID");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_PassengerID",
                table: "ticket",
                column: "PassengerID");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_SeatID",
                table: "ticket",
                column: "SeatID");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_TrainID",
                table: "ticket",
                column: "TrainID");

            migrationBuilder.CreateIndex(
                name: "IX_train_ArrivalStationID",
                table: "train",
                column: "ArrivalStationID");

            migrationBuilder.CreateIndex(
                name: "IX_train_DepartureStationID",
                table: "train",
                column: "DepartureStationID");

            migrationBuilder.CreateIndex(
                name: "IX_trainCarriage_TrainID",
                table: "trainCarriage",
                column: "TrainID");

            migrationBuilder.CreateIndex(
                name: "IX_user_PassportData",
                table: "user",
                column: "PassportData",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ticket");

            migrationBuilder.DropTable(
                name: "trainCarriage");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "seat");

            migrationBuilder.DropTable(
                name: "train");

            migrationBuilder.DropTable(
                name: "carriage");

            migrationBuilder.DropTable(
                name: "station");
        }
    }
}
