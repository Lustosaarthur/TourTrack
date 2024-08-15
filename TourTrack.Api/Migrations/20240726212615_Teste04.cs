using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourTrack.Api.Migrations
{
    /// <inheritdoc />
    public partial class Teste04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Reviews",
                newName: "RatingReview");

            migrationBuilder.AddColumn<string>(
                name: "CountryName",
                table: "Attractions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Attractions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CountryName", "Rating" },
                values: new object[] { "Av. Gustave Eiffel, Paris, France", 5.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CountryName", "Rating" },
                values: new object[] { "Art Museum, Paris, France", 4.5 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CountryName", "Description", "Rating" },
                values: new object[] { "Place d'Armes, Versailles, France", "The Palace of Versailles is a former royal residence commissioned by King Louis XIV located in Versailles, about 19 kilometers west of Paris, France.", 5.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CountryName", "Description", "Rating" },
                values: new object[] { "Normandy, France", "Mont-Saint-Michel is a tidal island and mainland commune in Normandy, France. The island lies approximately one kilometre off France's north-western coast, at the mouth of the Couesnon River near Avranches and is 7 hectares in area.", 4.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CountryName", "Description", "Rating" },
                values: new object[] { "Chambord, France", "The Château de Chambord in Chambord, Centre-Val de Loire, France, is one of the most recognisable châteaux in the world because of its very distinctive French Renaissance architecture, which blends traditional French medieval forms with classical Renaissance structures.", 4.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CountryName", "Description", "Rating" },
                values: new object[] { "Arizona, United States", "Grand Canyon National Park, in Arizona, is home to much of the immense Grand Canyon, with its layered bands of red rock revealing millions of years of geological history. Viewpoints include Mather Point, Yavapai Observation Station and architect Mary Colter’s Lookout Studio and her Desert View Watchtower. Lipan Point, with wide views of the canyon and Colorado River, is a popular, especially at sunrise and sunset.", 4.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CountryName", "Description", "Rating" },
                values: new object[] { "New York, United States", "The Statue of Liberty is a colossal neoclassical sculpture on Liberty Island in New York Harbor, within New York City. The copper-clad statue, a gift to the United States from the people of France, was designed by French sculptor Frédéric Auguste Bartholdi and its metal framework was built by Gustave Eiffel.", 5.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CountryName", "Description", "Rating" },
                values: new object[] { "United States", "Yellowstone National Park is a nearly 3,500-sq.-mile wilderness recreation area atop a volcanic hot spot. Mostly in Wyoming, the park spreads into parts of Montana and Idaho too. Yellowstone features dramatic canyons, alpine rivers, lush forests, hot springs and gushing geysers, including its most famous, Old Faithful. It's also home to hundreds of animal species, including bears, wolves, bison, elk and antelope.", 4.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CountryName", "Description", "Rating" },
                values: new object[] { "Florida, United States", "The Walt Disney World Resort is an entertainment resort complex located about 20 miles southwest of Orlando, Florida, United States. Opened on October 1, 1971, the resort is operated by Disney Experiences, a division of The Walt Disney Company. The property covers nearly 25,000 acres, of which half has been developed.", 5.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CountryName", "Description", "Rating" },
                values: new object[] { " San Francisco, Marin County", "The Golden Gate Bridge is a suspension bridge spanning the Golden Gate, the one-mile-wide strait connecting San Francisco Bay and the Pacific Ocean.", 4.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CountryName", "Description", "Rating" },
                values: new object[] { "Piazza del Colosseo, Roma RM, Italy", "The Colosseum is an elliptical amphitheatre in the centre of the city of Rome, Italy, just east of the Roman Forum. It is the largest ancient amphitheatre ever built, and is still the largest standing amphitheatre in the world, despite its age..", 5.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CountryName", "Rating" },
                values: new object[] { "Venice, Italy", 4.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CountryName", "Description", "Rating" },
                values: new object[] { " Piazza del Duomo, Pisa PI, Italy", "The Leaning Tower of Pisa, or simply the Tower of Pisa, is the campanile, or freestanding bell tower, of Pisa Cathedral. It is known for its nearly four-degree lean, the result of an unstable foundation.", 4.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CountryName", "Description", "Rating" },
                values: new object[] { "Piazza del Duomo, Firenze FI, Italy", "Florence Cathedral, formally the Cathedral of Saint Mary of the Flower, is the cathedral of Florence, Italy. It was begun in 1296 in the Gothic style to a design of Arnolfo di Cambio and was structurally completed by 1436, with the dome engineered by Filippo Brunelleschi.", 4.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CountryName", "Description", "Rating" },
                values: new object[] { "Amalfi, Province of Salerno, Italy", "The Amalfi Coast is a 50-kilometer stretch of coastline along the southern edge of Italy’s Sorrentine Peninsula, in the Campania region. It’s a popular holiday destination, with sheer cliffs and a rugged shoreline dotted with small beaches and pastel-colored fishing villages. The coastal road between the port city of Salerno and clifftop Sorrento winds past grand villas, terraced vineyards and cliffside lemon groves. ", 3.5 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CountryName", "Description", "Rating" },
                values: new object[] { "Japan", "apan’s Mt. Fuji is an active volcano about 100 kilometers southwest of Tokyo. Commonly called “Fuji-san,” it’s the country’s tallest peak, at 3,776 meters. A pilgrimage site for centuries, it’s considered one of Japan’s 3 sacred mountains, and summit hikes remain a popular activity. Its iconic profile is the subject of numerous works of art, notably Edo Period prints by Hokusai and Hiroshige.", 3.5 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CountryName", "Description", "Rating" },
                values: new object[] { "Minato City, Tokyo, Japan", "The Tokyo Tower is a communications and observation tower in the Shiba-koen district of Minato, Tokyo, Japan, built in 1958. At 332.9 meters, it was the tallest tower in Japan until the construction of Tokyo Skytree in 2012.", 3.5 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CountryName", "Description", "Rating" },
                values: new object[] { "Kyotogyoen, Kamigyo Ward, Kyoto, Japan", "In Japan, the Sentō Imperial Palace traditionally does not refer to a single location, but to any residence of retired emperors. Before Akihito abdicated in 2019, the last Emperor to retire did so in 1817, so the designation commonly refers to the historical Kyoto Sento Imperial Palace.", 0.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CountryName", "Description", "Rating" },
                values: new object[] { "Otemachi, Naka Ward, Hiroshima, Japan", "The Hiroshima Peace Memorial, originally the Hiroshima Prefectural Industrial Promotion Hall, and now commonly called the Genbaku Dome, Atomic Bomb Dome or A-Bomb Dome, is part of the Hiroshima Peace Memorial Park in Hiroshima, Japan and was designated a UNESCO World Heritage Site in 1996.", 4.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CountryName", "Description", "Rating" },
                values: new object[] { "Miyajimacho, Hatsukaichi, Hiroshima, Japan", "Itsukushima Shrine is a Shinto shrine on the island of Itsukushima, best known for its \"floating\" torii. It is in the city of Hatsukaichi, in Hiroshima Prefecture in Japan, accessible from the mainland by ferry at Miyajimaguchi Station.", 3.5 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CountryId", "CountryName", "Rating" },
                values: new object[] { 5, "Art Museum, Paris, France", 0.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CountryName", "Rating" },
                values: new object[] { "Art Museum, Paris, France", 0.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CountryName", "Rating" },
                values: new object[] { "Art Museum, Paris, France", 0.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CountryName", "Rating" },
                values: new object[] { "Art Museum, Paris, France", 0.0 });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CountryId", "CountryName", "Rating" },
                values: new object[] { 5, "Australia", 0.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryName",
                table: "Attractions");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Attractions");

            migrationBuilder.RenameColumn(
                name: "RatingReview",
                table: "Reviews",
                newName: "Rating");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "A grand palace near Paris, known for its opulent architecture and gardens.");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "An island commune in Normandy, known for its medieval architecture and tides.");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "A Renaissance castle in the Loire Valley, noted for its distinctive French Renaissance architecture.");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "A steep-sided canyon carved by the Colorado River in Arizona.");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "A symbol of freedom and democracy, located in New York Harbor.");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "A vast national park in Wyoming, known for its geothermal features.");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "An entertainment complex near Orlando, Florida, featuring theme parks and resorts.");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "An iconic suspension bridge connecting San Francisco to Marin County.");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "An ancient amphitheater in Rome, known for gladiatorial contests.");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "A freestanding bell tower, known for its unintended tilt.");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Cathedral with a terracotta-tiled dome by Brunelleschi and a bell tower by Giotto.");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "A picturesque coastline in southern Italy, known for its steep cliffs and scenic views.");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "An iconic volcano and highest peak in Japan.");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "An iconic communications and observation tower in Tokyo.");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Former ruling palace of the Emperor of Japan.");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "A memorial park in Hiroshima, dedicated to the legacy of atomic bombing.");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "A Shinto shrine on the island of Itsukushima, known for its 'floating' torii gate.");

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CountryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CountryId",
                value: 4);
        }
    }
}
