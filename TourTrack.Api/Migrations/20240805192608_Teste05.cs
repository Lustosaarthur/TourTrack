using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourTrack.Api.Migrations
{
    /// <inheritdoc />
    public partial class Teste05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Accommodations_AccommodationId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_AccommodationId",
                table: "Reviews");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Accommodations",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Amenities",
                table: "Accommodations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "CheckInTime",
                table: "Accommodations",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "CheckOutTime",
                table: "Accommodations",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Accommodations",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Policies",
                table: "Accommodations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Accommodations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Paris Hotel", "Wi-Fi, Parking, Pool, Gym, Spa", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "France", "Free cancellation up to 24 hours before check-in.", 4.5 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Eiffel View Hotel", "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "France", "Free cancellation up to 24 hours before check-in.", 5.0 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Tower Stay", "Wi-Fi, Parking, Pool, Gym", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "France", "Free cancellation up to 24 hours before check-in.", 3.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Louvre Inn", "Wi-Fi, Parking, Pool, Gym, Spa", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "France", "Free cancellation up to 24 hours before check-in.", 4.0 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Art Museum Hotel", "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "France", "Free cancellation up to 24 hours before check-in.", 4.5 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Louvre Luxury Suites", "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant, Bar", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "France", "Free cancellation up to 24 hours before check-in.", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Versailles Grand Hotel", "Wi-Fi, Parking, Pool, Gym, Spa", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "France", "Free cancellation up to 24 hours before check-in.", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Royal Stay Versailles", "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant, Bar", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "France", "Free cancellation up to 24 hours before check-in.", 4.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Palace View Inn", "Wi-Fi, Parking, Pool, Gym", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "France", "Free cancellation up to 24 hours before check-in.", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Mont Saint-Michel Hotel", "Wi-Fi, Parking, Pool, Gym, Spa", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "France", "Free cancellation up to 24 hours before check-in.", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Island Retreat", "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "France", "Free cancellation up to 24 hours before check-in.", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Saint-Michel Stay", "Wi-Fi, Parking, Pool, Gym", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "France", "Free cancellation up to 24 hours before check-in.", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Chambord Castle Hotel", "Wi-Fi, Parking, Pool, Gym, Spa", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "France", "Free cancellation up to 24 hours before check-in.", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Renaissance Inn", "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "France", "Free cancellation up to 24 hours before check-in.", 4.5 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Castle View Lodge", "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant, Bar", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "France", "Free cancellation up to 24 hours before check-in.", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Great Wall Hotel", "Wi-Fi, Parking, Pool, Gym, Spa", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 12, 0, 0, 0), "China", "Hotel with views of the Great Wall", "Great Wall Hotel", "Free cancellation up to 24 hours before check-in.", "¥1500.00", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Wallside Retreat", "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 12, 0, 0, 0), "China", "Retreat with Great Wall views", "Wallside Retreat", "Free cancellation up to 24 hours before check-in.", "¥1800.00", 4.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Historic Wall Hotel", "Wi-Fi, Parking, Pool, Gym", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 12, 0, 0, 0), "China", "Historic hotel near the Great Wall", "Historic Wall Hotel", "Free cancellation up to 24 hours before check-in.", "¥1300.00", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Forbidden City Hotel", "Wi-Fi, Parking, Pool, Gym, Spa", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 12, 0, 0, 0), "China", "Luxurious stay near Forbidden City", "Forbidden City Hotel", "Free cancellation up to 24 hours before check-in.", "¥2000.00", 5.0 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Imperial Palace Inn", "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 12, 0, 0, 0), "China", "Comfortable inn near Forbidden City", "Imperial Palace Inn", "Free cancellation up to 24 hours before check-in.", "¥1700.00", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Palace View Hotel", "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant, Bar", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 12, 0, 0, 0), "China", "Hotel with Forbidden City views", "Palace View Hotel", "Free cancellation up to 24 hours before check-in.", "¥1500.00", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Terracotta Warriors Hotel", "Wi-Fi, Parking, Pool, Gym, Spa", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 12, 0, 0, 0), "China", "Stay near the Terracotta Warriors", "Terracotta Warriors Hotel", "Free cancellation up to 24 hours before check-in.", "¥1600.00", 4.5 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Warriors' Retreat", "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 12, 0, 0, 0), "China", "Retreat near Terracotta Warriors", "Warriors' Retreat", "Free cancellation up to 24 hours before check-in.", "¥1900.00", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Historic Warriors Hotel", "Wi-Fi, Parking, Pool, Gym", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 12, 0, 0, 0), "China", "Historic hotel near Terracotta Warriors", "Historic Warriors Hotel", "Free cancellation up to 24 hours before check-in.", "¥1400.00", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Stonehenge Lodge", "Wi-Fi, Parking, Pool, Gym, Spa", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "United Kingdom", "Lodge near Stonehenge", "Stonehenge Lodge", "Free cancellation up to 24 hours before check-in.", "£150.00", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Henge Retreat", "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "United Kingdom", "Retreat with Stonehenge views", "Henge Retreat", "Free cancellation up to 24 hours before check-in.", "£180.00", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Historic Henge Hotel", "Wi-Fi, Parking, Pool, Gym", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "United Kingdom", "Historic hotel near Stonehenge", "Historic Henge Hotel", "Free cancellation up to 24 hours before check-in.", "£140.00", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Edinburgh Castle Hotel", "Wi-Fi, Parking, Pool, Gym, Spa", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "United Kingdom", "Stay near Edinburgh Castle", "Edinburgh Castle Hotel", "Free cancellation up to 24 hours before check-in.", "£200.00", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Castle View Inn", "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "United Kingdom", "Inn with views of Edinburgh Castle", "Castle View Inn", "Free cancellation up to 24 hours before check-in.", "£170.00", 4.5 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Historic Castle Stay", "Wi-Fi, Parking, Pool, Gym", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "United Kingdom", "Historic stay near Edinburgh Castle", "Historic Castle Stay", "Free cancellation up to 24 hours before check-in.", "£160.00", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Westminster Abbey Hotel", "Wi-Fi, Parking, Pool, Gym, Spa", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "United Kingdom", "Luxury hotel near Westminster Abbey", "Westminster Abbey Hotel", "Free cancellation up to 24 hours before check-in.", "£220.00", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Abbey View Inn", "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "United Kingdom", "Inn with views of Westminster Abbey", "Abbey View Inn", "Free cancellation up to 24 hours before check-in.", "£190.00", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Historic Abbey Hotel", "Wi-Fi, Parking, Pool, Gym", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "United Kingdom", "Historic hotel near Westminster Abbey", "Historic Abbey Hotel", "Free cancellation up to 24 hours before check-in.", "£180.00", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Vatican View Hotel", "Wi-Fi, Parking, Pool, Gym, Spa", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Italy", "Stay near the Vatican", "Vatican View Hotel", "Free cancellation up to 24 hours before check-in.", "€250.00", 4.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of St. Peter's Inn", "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Italy", "Inn with views of St. Peter's Basilica", "St. Peter's Inn", "Free cancellation up to 24 hours before check-in.", "€220.00", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Historic Vatican Hotel", "Wi-Fi, Parking, Pool, Gym", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Italy", "Historic hotel near the Vatican", "Historic Vatican Hotel", "Free cancellation up to 24 hours before check-in.", "€200.00", 4.5 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Colosseum Stay", "Wi-Fi, Parking, Pool, Gym, Spa", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Italy", "Hotel near the Colosseum", "Colosseum Stay", "Free cancellation up to 24 hours before check-in.", "€230.00", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Gladiator's Retreat", "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Italy", "Stay with views of the Colosseum", "Gladiator's Retreat", "Free cancellation up to 24 hours before check-in.", "€250.00", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Historic Colosseum Hotel", "Wi-Fi, Parking, Pool, Gym", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Italy", "Historic stay near the Colosseum", "Historic Colosseum Hotel", "Free cancellation up to 24 hours before check-in.", "€200.00", 4.5 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Leaning Tower Lodge", "Wi-Fi, Parking, Pool, Gym, Spa", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Italy", "Lodge near the Leaning Tower of Pisa", "Leaning Tower Lodge", "Free cancellation up to 24 hours before check-in.", "€190.00", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Tower View Inn", "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Italy", "Inn with views of the Leaning Tower", "Tower View Inn", "Free cancellation up to 24 hours before check-in.", "€210.00", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Historic Tower Hotel", "Wi-Fi, Parking, Pool, Gym", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Italy", "Historic stay near the Leaning Tower", "Historic Tower Hotel", "Free cancellation up to 24 hours before check-in.", "€180.00", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Venetian Canal Hotel", "Wi-Fi, Parking, Pool, Gym, Spa", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Italy", "Stay near the Grand Canal in Venice", "Venetian Canal Hotel", "Free cancellation up to 24 hours before check-in.", "€300.00", 4.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Grand Canal View Inn", "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Italy", "Inn with views of the Grand Canal", "Grand Canal View Inn", "Free cancellation up to 24 hours before check-in.", "€280.00", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Description", "Name", "Policies", "PricePerNight", "Rating" },
                values: new object[] { "Address of Historic Canal Hotel", "Wi-Fi, Parking, Pool, Gym", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Italy", "Historic stay near the Grand Canal", "Historic Canal Hotel", "Free cancellation up to 24 hours before check-in.", "€260.00", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Fuji Mountain Hotel", "Wi-Fi, Parking, Spa", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Japan", "Free cancellation up to 24 hours before check-in.", 4.5 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Volcano View Inn", "Wi-Fi, Parking, Restaurant", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Japan", "Free cancellation up to 24 hours before check-in.", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Fuji Stay", "Wi-Fi, Parking", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Japan", "Free cancellation up to 24 hours before check-in.", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Tokyo Tower Hotel", "Wi-Fi, Parking, Spa", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Japan", "Free cancellation up to 24 hours before check-in.", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Tower View Inn", "Wi-Fi, Parking, Restaurant", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Japan", "Free cancellation up to 24 hours before check-in.", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Tokyo Stay", "Wi-Fi, Parking", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Japan", "Free cancellation up to 24 hours before check-in.", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Imperial Palace Hotel", "Wi-Fi, Parking, Spa", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Japan", "Free cancellation up to 24 hours before check-in.", 4.5 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Palace View Inn", "Wi-Fi, Parking, Restaurant", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Japan", "Free cancellation up to 24 hours before check-in.", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Kyoto Stay", "Wi-Fi, Parking", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Japan", "Free cancellation up to 24 hours before check-in.", 4.0 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Hiroshima Memorial Hotel", "Wi-Fi, Parking, Spa", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Japan", "Free cancellation up to 24 hours before check-in.", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Peace Park Inn", "Wi-Fi, Parking, Restaurant", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Japan", "Free cancellation up to 24 hours before check-in.", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Memorial Stay", "Wi-Fi, Parking", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Japan", "Free cancellation up to 24 hours before check-in.", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Itsukushima Shrine Hotel", "Wi-Fi, Parking, Spa", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Japan", "Free cancellation up to 24 hours before check-in.", 4.5 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Floating Torii Inn", "Wi-Fi, Parking, Restaurant", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Japan", "Free cancellation up to 24 hours before check-in.", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Shrine Stay", "Wi-Fi, Parking", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Japan", "Free cancellation up to 24 hours before check-in.", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Opera House Hotel", "Wi-Fi, Parking, Spa", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Australia", "Free cancellation up to 24 hours before check-in.", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Harbour View Inn", "Wi-Fi, Parking, Restaurant", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Australia", "Free cancellation up to 24 hours before check-in.", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Opera Stay", "Wi-Fi, Parking", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Australia", "Free cancellation up to 24 hours before check-in.", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Reef View Hotel", "Wi-Fi, Parking, Spa", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Australia", "Free cancellation up to 24 hours before check-in.", 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Coral Inn", "Wi-Fi, Parking, Restaurant", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Australia", "Free cancellation up to 24 hours before check-in.", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Reef Stay", "Wi-Fi, Parking", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Australia", "Free cancellation up to 24 hours before check-in.", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Uluru View Hotel", "Wi-Fi, Parking, Spa", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Australia", "Free cancellation up to 24 hours before check-in.", 4.5 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Rock Inn", "Wi-Fi, Parking, Restaurant", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Australia", "Free cancellation up to 24 hours before check-in.", 4.2000000000000002 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Uluru Stay", "Wi-Fi, Parking", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Australia", "Free cancellation up to 24 hours before check-in.", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Bondi Beach Hotel", "Wi-Fi, Parking, Spa", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Australia", "Free cancellation up to 24 hours before check-in.", 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Beachfront Inn", "Wi-Fi, Parking, Restaurant", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Australia", "Free cancellation up to 24 hours before check-in.", 4.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Bondi Stay", "Wi-Fi, Parking", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Australia", "Free cancellation up to 24 hours before check-in.", 4.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Ocean Road Hotel", "Wi-Fi, Parking, Spa", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Australia", "Free cancellation up to 24 hours before check-in.", 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Coastal Inn", "Wi-Fi, Parking, Restaurant", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Australia", "Free cancellation up to 24 hours before check-in.", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Address", "Amenities", "CheckInTime", "CheckOutTime", "Country", "Policies", "Rating" },
                values: new object[] { "Address of Ocean Stay", "Wi-Fi, Parking", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Australia", "Free cancellation up to 24 hours before check-in.", 4.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Accommodations");

            migrationBuilder.DropColumn(
                name: "Amenities",
                table: "Accommodations");

            migrationBuilder.DropColumn(
                name: "CheckInTime",
                table: "Accommodations");

            migrationBuilder.DropColumn(
                name: "CheckOutTime",
                table: "Accommodations");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Accommodations");

            migrationBuilder.DropColumn(
                name: "Policies",
                table: "Accommodations");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Accommodations");

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Lodge within Grand Canyon National Park", "Grand Canyon Lodge", "$180.00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Hotel with breathtaking canyon views", "Canyon View Hotel", "$220.00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Comfortable stay near Grand Canyon", "Canyon Stay Inn", "$150.00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Hotel with views of the Statue of Liberty", "Liberty View Hotel", "$200.00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Comfortable stay near the Statue of Liberty", "Freedom Stay", "$180.00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Inn close to the Statue of Liberty", "Liberty Inn", "$150.00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Lodge within Yellowstone National Park", "Yellowstone Lodge", "$220.00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Hotel with views of geysers", "Geyser View Hotel", "$200.00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Inn close to geothermal features", "Park Stay Inn", "$170.00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Hotel within Walt Disney World Resort", "Disney World Hotel", "$300.00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Inn close to Magic Kingdom", "Magic Kingdom Inn", "$250.00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Comfortable stay near Disney parks", "Disney Stay", "$200.00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Hotel with views of Golden Gate Bridge", "Golden Gate Hotel", "$220.00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Inn with bridge views", "Bridge View Inn", "$180.00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Comfortable stay near the bridge", "San Francisco Stay", "$150.00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Hotel with views of the Colosseum", "Rome Colosseum Hotel", "€200,00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Inn close to the Colosseum", "Ancient Rome Inn", "€180,00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Comfortable stay near the Colosseum", "Gladiator Stay", "€160,00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Hotel with views of the Venice Canals", "Venice Canal Hotel", "€220,00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Inn close to the canals", "Waterway Inn", "€200,00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Comfortable stay near the canals", "Gondola Stay", "€180,00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Hotel with views of the Leaning Tower", "Pisa Tower Hotel", "€180,00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Inn close to the Leaning Tower", "Tower View Inn", "€160,00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Comfortable stay near the tower", "Leaning Stay", "€140,00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Hotel with views of the Florence Cathedral", "Florence Cathedral Hotel", "€220,00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Inn close to the cathedral", "Dome View Inn", "€200,00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Comfortable stay near the cathedral", "Cathedral Stay", "€180,00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Hotel with views of the Amalfi Coast", "Amalfi Coast Hotel", "€250,00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Inn close to the coast", "Coastal Inn", "€220,00" });

            migrationBuilder.UpdateData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "Name", "PricePerNight" },
                values: new object[] { "Comfortable stay near the coast", "Seaside Stay", "€200,00" });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_AccommodationId",
                table: "Reviews",
                column: "AccommodationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Accommodations_AccommodationId",
                table: "Reviews",
                column: "AccommodationId",
                principalTable: "Accommodations",
                principalColumn: "Id");
        }
    }
}
