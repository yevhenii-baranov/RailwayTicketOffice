﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RailwayTicketOffice.Database;

namespace RailwayTicketOffice.Migrations
{
    [DbContext(typeof(MySqlDbContext))]
    [Migration("20181225145658_trainid2")]
    partial class trainid2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("RailwayTicketOffice.Entity.Carriage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarriageType");

                    b.HasKey("ID");

                    b.ToTable("carriage");
                });

            modelBuilder.Entity("RailwayTicketOffice.Entity.CarriageSeat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarriageID");

                    b.Property<int>("NumberInCarriage");

                    b.Property<short>("Ordered")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue((short)0);

                    b.HasKey("ID");

                    b.HasIndex("CarriageID");

                    b.ToTable("seat");
                });

            modelBuilder.Entity("RailwayTicketOffice.Entity.Ticket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PassengerID");

                    b.Property<decimal>("Price");

                    b.Property<int>("SeatID");

                    b.Property<int>("TicketType");

                    b.Property<int>("TrainID");

                    b.HasKey("ID");

                    b.HasIndex("PassengerID");

                    b.HasIndex("SeatID");

                    b.HasIndex("TrainID");

                    b.ToTable("ticket");
                });

            modelBuilder.Entity("RailwayTicketOffice.Entity.Train", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArrivalStationID");

                    b.Property<long>("ArrivalTime")
                        .HasColumnType("bigint");

                    b.Property<int>("DepartureStationID");

                    b.Property<long>("DepartureTime")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("ArrivalStationID");

                    b.HasIndex("DepartureStationID");

                    b.ToTable("train");
                });

            modelBuilder.Entity("RailwayTicketOffice.Entity.TrainCarriage", b =>
                {
                    b.Property<int>("CarriageID");

                    b.Property<int>("TrainID");

                    b.HasKey("CarriageID", "TrainID");

                    b.HasIndex("TrainID");

                    b.ToTable("trainCarriage");
                });

            modelBuilder.Entity("RailwayTicketOffice.Entity.TrainStation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("station");
                });

            modelBuilder.Entity("RailwayTicketOffice.Entity.Trip", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TrainId");

                    b.Property<DateTime>("TripDate");

                    b.HasKey("ID");

                    b.HasIndex("TrainId");

                    b.ToTable("trip");
                });

            modelBuilder.Entity("RailwayTicketOffice.Entity.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("PassportData");

                    b.Property<string>("Password");

                    b.Property<int>("UserRole");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.HasIndex("PassportData")
                        .IsUnique();

                    b.ToTable("user");
                });

            modelBuilder.Entity("RailwayTicketOffice.Entity.CarriageSeat", b =>
                {
                    b.HasOne("RailwayTicketOffice.Entity.Carriage", "Carriage")
                        .WithMany()
                        .HasForeignKey("CarriageID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RailwayTicketOffice.Entity.Ticket", b =>
                {
                    b.HasOne("RailwayTicketOffice.Entity.User", "Passenger")
                        .WithMany()
                        .HasForeignKey("PassengerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RailwayTicketOffice.Entity.CarriageSeat", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RailwayTicketOffice.Entity.Train", "Train")
                        .WithMany()
                        .HasForeignKey("TrainID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RailwayTicketOffice.Entity.Train", b =>
                {
                    b.HasOne("RailwayTicketOffice.Entity.TrainStation", "ArrivalStation")
                        .WithMany()
                        .HasForeignKey("ArrivalStationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RailwayTicketOffice.Entity.TrainStation", "DepartureStation")
                        .WithMany()
                        .HasForeignKey("DepartureStationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RailwayTicketOffice.Entity.TrainCarriage", b =>
                {
                    b.HasOne("RailwayTicketOffice.Entity.Carriage", "Carriage")
                        .WithMany("TrainCarriages")
                        .HasForeignKey("CarriageID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RailwayTicketOffice.Entity.Train", "Train")
                        .WithMany("TrainCarriages")
                        .HasForeignKey("TrainID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RailwayTicketOffice.Entity.Trip", b =>
                {
                    b.HasOne("RailwayTicketOffice.Entity.Train", "Train")
                        .WithMany("Trips")
                        .HasForeignKey("TrainId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
