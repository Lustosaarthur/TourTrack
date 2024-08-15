using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourTrack.Api.Migrations
{
    /// <inheritdoc />
    public partial class Teste02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccommodationImage_Accommodations_AccommodationId",
                table: "AccommodationImage");

            migrationBuilder.DropForeignKey(
                name: "FK_AttractionImage_Attractions_AttractionId",
                table: "AttractionImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttractionImage",
                table: "AttractionImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccommodationImage",
                table: "AccommodationImage");

            migrationBuilder.RenameTable(
                name: "AttractionImage",
                newName: "attractionImages");

            migrationBuilder.RenameTable(
                name: "AccommodationImage",
                newName: "accommodationImages");

            migrationBuilder.RenameIndex(
                name: "IX_AttractionImage_AttractionId",
                table: "attractionImages",
                newName: "IX_attractionImages_AttractionId");

            migrationBuilder.RenameIndex(
                name: "IX_AccommodationImage_AccommodationId",
                table: "accommodationImages",
                newName: "IX_accommodationImages_AccommodationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_attractionImages",
                table: "attractionImages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_accommodationImages",
                table: "accommodationImages",
                column: "Id");

            migrationBuilder.InsertData(
                table: "attractionImages",
                columns: new[] { "Id", "AttractionId", "Url" },
                values: new object[,]
                {
                    { 1, 1, "Teste01" },
                    { 2, 1, "Teste02" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_accommodationImages_Accommodations_AccommodationId",
                table: "accommodationImages",
                column: "AccommodationId",
                principalTable: "Accommodations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_attractionImages_Attractions_AttractionId",
                table: "attractionImages",
                column: "AttractionId",
                principalTable: "Attractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_accommodationImages_Accommodations_AccommodationId",
                table: "accommodationImages");

            migrationBuilder.DropForeignKey(
                name: "FK_attractionImages_Attractions_AttractionId",
                table: "attractionImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_attractionImages",
                table: "attractionImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_accommodationImages",
                table: "accommodationImages");

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "attractionImages",
                newName: "AttractionImage");

            migrationBuilder.RenameTable(
                name: "accommodationImages",
                newName: "AccommodationImage");

            migrationBuilder.RenameIndex(
                name: "IX_attractionImages_AttractionId",
                table: "AttractionImage",
                newName: "IX_AttractionImage_AttractionId");

            migrationBuilder.RenameIndex(
                name: "IX_accommodationImages_AccommodationId",
                table: "AccommodationImage",
                newName: "IX_AccommodationImage_AccommodationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttractionImage",
                table: "AttractionImage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccommodationImage",
                table: "AccommodationImage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AccommodationImage_Accommodations_AccommodationId",
                table: "AccommodationImage",
                column: "AccommodationId",
                principalTable: "Accommodations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttractionImage_Attractions_AttractionId",
                table: "AttractionImage",
                column: "AttractionId",
                principalTable: "Attractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
