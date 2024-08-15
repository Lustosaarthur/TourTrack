using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourTrack.Models.Migrations
{
    /// <inheritdoc />
    public partial class DbInity02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccommodationsDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    AttractionId = table.Column<int>(type: "INTEGER", nullable: false),
                    PricePerNight = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Country = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Policies = table.Column<string>(type: "TEXT", nullable: false),
                    CheckInTime = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    CheckOutTime = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    Amenities = table.Column<string>(type: "TEXT", nullable: false),
                    Rating = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccommodationsDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttractionsDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    Rating = table.Column<double>(type: "REAL", nullable: false),
                    Latitude = table.Column<double>(type: "REAL", nullable: false),
                    Longitude = table.Column<double>(type: "REAL", nullable: false),
                    CountryId = table.Column<int>(type: "INTEGER", nullable: false),
                    OpeningHours = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    EntryFee = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CountryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttractionsDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccommodationImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    AccommodationId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccommodationImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccommodationImage_AccommodationsDb_AccommodationId",
                        column: x => x.AccommodationId,
                        principalTable: "AccommodationsDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    AttractionId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_AttractionsDb_AttractionId",
                        column: x => x.AttractionId,
                        principalTable: "AttractionsDb",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    RatingReview = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    AttractionId = table.Column<int>(type: "INTEGER", nullable: true),
                    AccommodationId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_AttractionsDb_AttractionId",
                        column: x => x.AttractionId,
                        principalTable: "AttractionsDb",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccommodationImage_AccommodationId",
                table: "AccommodationImage",
                column: "AccommodationId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_AttractionId",
                table: "Images",
                column: "AttractionId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_AttractionId",
                table: "Review",
                column: "AttractionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccommodationImage");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "AccommodationsDb");

            migrationBuilder.DropTable(
                name: "AttractionsDb");
        }
    }
}
