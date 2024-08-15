using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourTrack.Api.Migrations
{
    /// <inheritdoc />
    public partial class Teste03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AttractiondId",
                table: "Accommodations",
                newName: "AttractionId");

            migrationBuilder.InsertData(
                table: "Accommodations",
                columns: new[] { "Id", "AttractionId", "Description", "Name", "PricePerNight" },
                values: new object[,]
                {
                    { 1, 1, "A hotel with a view of the Eiffel Tower", "Paris Hotel", "€230,00" },
                    { 2, 1, "Luxury hotel with Eiffel Tower view", "Eiffel View Hotel", "€350,00" },
                    { 3, 1, "Comfortable stay near Eiffel Tower", "Tower Stay", "€150,00" },
                    { 4, 2, "Boutique hotel near the Louvre", "Louvre Inn", "€200,00" },
                    { 5, 2, "Stylish hotel close to the Louvre", "Art Museum Hotel", "€270,00" },
                    { 6, 2, "Luxury suites with museum views", "Louvre Luxury Suites", "€320,00" },
                    { 7, 3, "Elegant hotel near Versailles Palace", "Versailles Grand Hotel", "€300,00" },
                    { 8, 3, "Royal experience near the palace", "Royal Stay Versailles", "€400,00" },
                    { 9, 3, "Comfortable stay near Versailles", "Palace View Inn", "€250,00" },
                    { 10, 4, "Cozy hotel on Mont Saint-Michel", "Mont Saint-Michel Hotel", "€180,00" },
                    { 11, 4, "Charming retreat on the island", "Island Retreat", "€220,00" },
                    { 12, 4, "Historic stay on Mont Saint-Michel", "Saint-Michel Stay", "€200,00" },
                    { 13, 5, "Stay in a castle near Chambord", "Chambord Castle Hotel", "€280,00" },
                    { 14, 5, "Historic inn near Château de Chambord", "Renaissance Inn", "€240,00" },
                    { 15, 5, "Lodge with views of the castle", "Castle View Lodge", "€260,00" },
                    { 16, 6, "Lodge within Grand Canyon National Park", "Grand Canyon Lodge", "$180.00" },
                    { 17, 6, "Hotel with breathtaking canyon views", "Canyon View Hotel", "$220.00" },
                    { 18, 6, "Comfortable stay near Grand Canyon", "Canyon Stay Inn", "$150.00" },
                    { 19, 7, "Hotel with views of the Statue of Liberty", "Liberty View Hotel", "$200.00" },
                    { 20, 7, "Comfortable stay near the Statue of Liberty", "Freedom Stay", "$180.00" },
                    { 21, 7, "Inn close to the Statue of Liberty", "Liberty Inn", "$150.00" },
                    { 22, 8, "Lodge within Yellowstone National Park", "Yellowstone Lodge", "$220.00" },
                    { 23, 8, "Hotel with views of geysers", "Geyser View Hotel", "$200.00" },
                    { 24, 8, "Inn close to geothermal features", "Park Stay Inn", "$170.00" },
                    { 25, 9, "Hotel within Walt Disney World Resort", "Disney World Hotel", "$300.00" },
                    { 26, 9, "Inn close to Magic Kingdom", "Magic Kingdom Inn", "$250.00" },
                    { 27, 9, "Comfortable stay near Disney parks", "Disney Stay", "$200.00" },
                    { 28, 10, "Hotel with views of Golden Gate Bridge", "Golden Gate Hotel", "$220.00" },
                    { 29, 10, "Inn with bridge views", "Bridge View Inn", "$180.00" },
                    { 30, 10, "Comfortable stay near the bridge", "San Francisco Stay", "$150.00" },
                    { 31, 11, "Hotel with views of the Colosseum", "Rome Colosseum Hotel", "€200,00" },
                    { 32, 11, "Inn close to the Colosseum", "Ancient Rome Inn", "€180,00" },
                    { 33, 11, "Comfortable stay near the Colosseum", "Gladiator Stay", "€160,00" },
                    { 34, 12, "Hotel with views of the Venice Canals", "Venice Canal Hotel", "€220,00" },
                    { 35, 12, "Inn close to the canals", "Waterway Inn", "€200,00" },
                    { 36, 12, "Comfortable stay near the canals", "Gondola Stay", "€180,00" },
                    { 37, 13, "Hotel with views of the Leaning Tower", "Pisa Tower Hotel", "€180,00" },
                    { 38, 13, "Inn close to the Leaning Tower", "Tower View Inn", "€160,00" },
                    { 39, 13, "Comfortable stay near the tower", "Leaning Stay", "€140,00" },
                    { 40, 14, "Hotel with views of the Florence Cathedral", "Florence Cathedral Hotel", "€220,00" },
                    { 41, 14, "Inn close to the cathedral", "Dome View Inn", "€200,00" },
                    { 42, 14, "Comfortable stay near the cathedral", "Cathedral Stay", "€180,00" },
                    { 43, 15, "Hotel with views of the Amalfi Coast", "Amalfi Coast Hotel", "€250,00" },
                    { 44, 15, "Inn close to the coast", "Coastal Inn", "€220,00" },
                    { 45, 15, "Comfortable stay near the coast", "Seaside Stay", "€200,00" },
                    { 46, 16, "Hotel with views of Mount Fuji", "Fuji Mountain Hotel", "¥12000" },
                    { 47, 16, "Inn close to Mount Fuji", "Volcano View Inn", "¥10000" },
                    { 48, 16, "Comfortable stay near the mountain", "Fuji Stay", "¥8000" },
                    { 49, 17, "Hotel with views of Tokyo Tower", "Tokyo Tower Hotel", "¥14000" },
                    { 50, 17, "Inn close to Tokyo Tower", "Tower View Inn", "¥12000" },
                    { 51, 17, "Comfortable stay near the tower", "Tokyo Stay", "¥10000" },
                    { 52, 18, "Hotel with views of Kyoto Imperial Palace", "Imperial Palace Hotel", "¥10000" },
                    { 53, 18, "Inn close to the Imperial Palace", "Palace View Inn", "¥8000" },
                    { 54, 18, "Comfortable stay near the palace", "Kyoto Stay", "¥6000" },
                    { 55, 19, "Hotel close to Hiroshima Peace Memorial", "Hiroshima Memorial Hotel", "¥8000" },
                    { 56, 19, "Inn near Hiroshima Peace Memorial", "Peace Park Inn", "¥7000" },
                    { 57, 19, "Comfortable stay near the memorial", "Memorial Stay", "¥6000" },
                    { 58, 20, "Hotel with views of Itsukushima Shrine", "Itsukushima Shrine Hotel", "¥9000" },
                    { 59, 20, "Inn close to the shrine", "Floating Torii Inn", "¥8000" },
                    { 60, 20, "Comfortable stay near the shrine", "Shrine Stay", "¥7000" },
                    { 61, 21, "Hotel with views of Sydney Opera House", "Opera House Hotel", "AUD 250.00" },
                    { 62, 21, "Inn close to Sydney Harbour", "Harbour View Inn", "AUD 200.00" },
                    { 63, 21, "Comfortable stay near the Opera House", "Opera Stay", "AUD 180.00" },
                    { 64, 22, "Hotel with views of the Great Barrier Reef", "Reef View Hotel", "AUD 300.00" },
                    { 65, 22, "Inn close to the reef", "Coral Inn", "AUD 250.00" },
                    { 66, 22, "Comfortable stay near the reef", "Reef Stay", "AUD 200.00" },
                    { 67, 23, "Hotel with views of Uluru", "Uluru View Hotel", "AUD 280.00" },
                    { 68, 23, "Inn close to Uluru", "Rock Inn", "AUD 240.00" },
                    { 69, 23, "Comfortable stay near Uluru", "Uluru Stay", "AUD 200.00" },
                    { 70, 24, "Hotel with views of Bondi Beach", "Bondi Beach Hotel", "AUD 260.00" },
                    { 71, 24, "Inn close to Bondi Beach", "Beachfront Inn", "AUD 220.00" },
                    { 72, 24, "Comfortable stay near the beach", "Bondi Stay", "AUD 180.00" },
                    { 73, 25, "Hotel with views of the Great Ocean Road", "Ocean Road Hotel", "AUD 280.00" },
                    { 74, 25, "Inn close to the Great Ocean Road", "Coastal Inn", "AUD 240.00" },
                    { 75, 25, "Comfortable stay near the ocean", "Ocean Stay", "AUD 200.00" }
                });

            migrationBuilder.InsertData(
                table: "Attractions",
                columns: new[] { "Id", "CountryId", "Description", "EntryFee", "Latitude", "Longitude", "Name", "OpeningHours" },
                values: new object[,]
                {
                    { 2, 1, "The world's largest art museum and a historic monument in Paris.", "€17", 48.860599999999998, 2.3376000000000001, "Louvre Museum", "09:00 - 18:00" },
                    { 3, 1, "A grand palace near Paris, known for its opulent architecture and gardens.", "€18", 48.804699999999997, 2.1204000000000001, "Versailles Palace", "09:00 - 18:30" },
                    { 4, 1, "An island commune in Normandy, known for its medieval architecture and tides.", "€10", 48.636699999999998, -1.5113000000000001, "Mont Saint-Michel", "09:30 - 18:00" },
                    { 5, 1, "A Renaissance castle in the Loire Valley, noted for its distinctive French Renaissance architecture.", "€14", 47.616599999999998, 1.5197000000000001, "Château de Chambord", "09:00 - 18:00" },
                    { 6, 2, "A steep-sided canyon carved by the Colorado River in Arizona.", "$35 per vehicle", 36.106900000000003, -112.1129, "Grand Canyon National Park", "24 hours" },
                    { 7, 2, "A symbol of freedom and democracy, located in New York Harbor.", "$18.50", 40.6892, -74.044499999999999, "Statue of Liberty", "08:30 - 16:00" },
                    { 8, 2, "A vast national park in Wyoming, known for its geothermal features.", "$35 per vehicle", 44.427999999999997, -110.5885, "Yellowstone National Park", "24 hours" },
                    { 9, 2, "An entertainment complex near Orlando, Florida, featuring theme parks and resorts.", "$109 and up", 28.385200000000001, -81.563900000000004, "Walt Disney World Resort", "Varies by park" },
                    { 10, 2, "An iconic suspension bridge connecting San Francisco to Marin County.", "Free", 37.819899999999997, -122.4783, "Golden Gate Bridge", "24 hours" },
                    { 11, 3, "An ancient amphitheater in Rome, known for gladiatorial contests.", "€16", 41.8902, 12.4922, "Colosseum", "08:30 - 19:15" },
                    { 12, 3, "Famous waterways and historic architecture in Venice.", "Free", 45.440800000000003, 12.3155, "Venice Canals", "24 hours" },
                    { 13, 3, "A freestanding bell tower, known for its unintended tilt.", "€18", 43.722999999999999, 10.396599999999999, "Leaning Tower of Pisa", "09:00 - 19:00" },
                    { 14, 3, "Cathedral with a terracotta-tiled dome by Brunelleschi and a bell tower by Giotto.", "€18", 43.773400000000002, 11.255100000000001, "Florence Cathedral", "10:00 - 17:00" },
                    { 15, 3, "A picturesque coastline in southern Italy, known for its steep cliffs and scenic views.", "Free", 40.634, 14.602600000000001, "Amalfi Coast", "24 hours" },
                    { 16, 4, "An iconic volcano and highest peak in Japan.", "¥1000", 35.360599999999998, 138.72739999999999, "Mount Fuji", "24 hours" },
                    { 17, 4, "An iconic communications and observation tower in Tokyo.", "¥1200", 35.6586, 139.74539999999999, "Tokyo Tower", "09:00 - 23:00" },
                    { 18, 4, "Former ruling palace of the Emperor of Japan.", "Free", 35.025399999999998, 135.7621, "Kyoto Imperial Palace", "09:00 - 17:00" },
                    { 19, 4, "A memorial park in Hiroshima, dedicated to the legacy of atomic bombing.", "¥200", 34.395499999999998, 132.45439999999999, "Hiroshima Peace Memorial", "08:30 - 18:00" },
                    { 20, 4, "A Shinto shrine on the island of Itsukushima, known for its 'floating' torii gate.", "¥300", 34.295299999999997, 132.31899999999999, "Itsukushima Shrine", "06:30 - 18:00" },
                    { 21, 4, "An iconic volcano and highest peak in Japan.", "¥1000", 35.360599999999998, 138.72739999999999, "Mount Fuji", "24 hours" },
                    { 22, 4, "An iconic communications and observation tower in Tokyo.", "¥1200", 35.6586, 139.74539999999999, "Tokyo Tower", "09:00 - 23:00" },
                    { 23, 4, "Former ruling palace of the Emperor of Japan.", "Free", 35.025399999999998, 135.7621, "Kyoto Imperial Palace", "09:00 - 17:00" },
                    { 24, 4, "A memorial park in Hiroshima, dedicated to the legacy of atomic bombing.", "¥200", 34.395499999999998, 132.45439999999999, "Hiroshima Peace Memorial", "08:30 - 18:00" },
                    { 25, 4, "A Shinto shrine on the island of Itsukushima, known for its 'floating' torii gate.", "¥300", 34.295299999999997, 132.31899999999999, "Itsukushima Shrine", "06:30 - 18:00" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 2, "US", "United States" },
                    { 3, "It", "Italy" },
                    { 4, "Jp", "Japan" },
                    { 5, "Au", "Australia" }
                });

            migrationBuilder.InsertData(
                table: "accommodationImages",
                columns: new[] { "Id", "AccommodationId", "Url" },
                values: new object[,]
                {
                    { 1, 1, "https://example.com/paris_hotel_1.jpg" },
                    { 2, 1, "https://example.com/paris_hotel_2.jpg" },
                    { 3, 2, "https://example.com/eiffel_inn_1.jpg" },
                    { 4, 2, "https://example.com/eiffel_inn_2.jpg" },
                    { 5, 3, "https://example.com/tower_stay_1.jpg" },
                    { 6, 3, "https://example.com/tower_stay_2.jpg" },
                    { 7, 4, "https://example.com/louvre_hotel_1.jpg" },
                    { 8, 4, "https://example.com/louvre_hotel_2.jpg" },
                    { 9, 5, "https://example.com/art_stay_1.jpg" },
                    { 10, 5, "https://example.com/art_stay_2.jpg" },
                    { 11, 6, "https://example.com/grand_canyon_lodge_1.jpg" },
                    { 12, 6, "https://example.com/grand_canyon_lodge_2.jpg" },
                    { 13, 7, "https://example.com/canyon_view_inn_1.jpg" },
                    { 14, 7, "https://example.com/canyon_view_inn_2.jpg" },
                    { 15, 8, "https://example.com/canyon_stay_1.jpg" },
                    { 16, 8, "https://example.com/canyon_stay_2.jpg" },
                    { 17, 9, "https://example.com/liberty_hotel_1.jpg" },
                    { 18, 9, "https://example.com/liberty_hotel_2.jpg" },
                    { 19, 10, "https://example.com/freedom_inn_1.jpg" },
                    { 20, 10, "https://example.com/freedom_inn_2.jpg" },
                    { 21, 11, "https://example.com/liberty_stay_1.jpg" },
                    { 22, 11, "https://example.com/liberty_stay_2.jpg" },
                    { 23, 12, "https://example.com/yellowstone_lodge_1.jpg" },
                    { 24, 12, "https://example.com/yellowstone_lodge_2.jpg" },
                    { 25, 13, "https://example.com/geyser_inn_1.jpg" },
                    { 26, 13, "https://example.com/geyser_inn_2.jpg" },
                    { 27, 14, "https://example.com/park_stay_1.jpg" },
                    { 28, 14, "https://example.com/park_stay_2.jpg" },
                    { 29, 15, "https://example.com/disney_hotel_1.jpg" },
                    { 30, 15, "https://example.com/disney_hotel_2.jpg" },
                    { 31, 16, "https://example.com/magic_inn_1.jpg" },
                    { 32, 16, "https://example.com/magic_inn_2.jpg" },
                    { 33, 17, "https://example.com/disney_stay_1.jpg" },
                    { 34, 17, "https://example.com/disney_stay_2.jpg" },
                    { 35, 18, "https://example.com/golden_gate_hotel_1.jpg" },
                    { 36, 18, "https://example.com/golden_gate_hotel_2.jpg" },
                    { 37, 19, "https://example.com/bridge_view_inn_1.jpg" },
                    { 38, 19, "https://example.com/bridge_view_inn_2.jpg" },
                    { 39, 20, "https://example.com/gate_stay_1.jpg" },
                    { 40, 20, "https://example.com/gate_stay_2.jpg" },
                    { 41, 21, "https://example.com/colosseum_hotel_1.jpg" },
                    { 42, 21, "https://example.com/colosseum_hotel_2.jpg" },
                    { 43, 22, "https://example.com/gladiator_inn_1.jpg" },
                    { 44, 22, "https://example.com/gladiator_inn_2.jpg" },
                    { 45, 23, "https://example.com/rome_stay_1.jpg" },
                    { 46, 23, "https://example.com/rome_stay_2.jpg" },
                    { 47, 24, "https://example.com/venice_hotel_1.jpg" },
                    { 48, 24, "https://example.com/venice_hotel_2.jpg" },
                    { 49, 25, "https://example.com/canal_view_inn_1.jpg" },
                    { 50, 25, "https://example.com/canal_view_inn_2.jpg" },
                    { 51, 26, "https://example.com/venice_stay_1.jpg" },
                    { 52, 26, "https://example.com/venice_stay_2.jpg" },
                    { 53, 27, "https://example.com/pisa_hotel_1.jpg" },
                    { 54, 27, "https://example.com/pisa_hotel_2.jpg" },
                    { 55, 28, "https://example.com/leaning_inn_1.jpg" },
                    { 56, 28, "https://example.com/leaning_inn_2.jpg" },
                    { 57, 29, "https://example.com/pisa_stay_1.jpg" },
                    { 58, 29, "https://example.com/pisa_stay_2.jpg" },
                    { 59, 30, "https://example.com/florence_hotel_1.jpg" },
                    { 60, 30, "https://example.com/florence_hotel_2.jpg" },
                    { 61, 31, "https://example.com/cathedral_inn_1.jpg" },
                    { 62, 31, "https://example.com/cathedral_inn_2.jpg" },
                    { 63, 32, "https://example.com/florence_stay_1.jpg" },
                    { 64, 32, "https://example.com/florence_stay_2.jpg" },
                    { 65, 33, "https://example.com/amalfi_hotel_1.jpg" },
                    { 66, 33, "https://example.com/amalfi_hotel_2.jpg" },
                    { 67, 34, "https://example.com/coast_view_inn_1.jpg" },
                    { 68, 34, "https://example.com/coast_view_inn_2.jpg" },
                    { 69, 35, "https://example.com/amalfi_stay_1.jpg" },
                    { 70, 35, "https://example.com/amalfi_stay_2.jpg" },
                    { 71, 36, "https://example.com/mount_fuji_hotel_1.jpg" },
                    { 72, 36, "https://example.com/mount_fuji_hotel_2.jpg" },
                    { 73, 37, "https://example.com/fuji_view_inn_1.jpg" },
                    { 74, 37, "https://example.com/fuji_view_inn_2.jpg" },
                    { 75, 38, "https://example.com/fuji_stay_1.jpg" },
                    { 76, 38, "https://example.com/fuji_stay_2.jpg" },
                    { 77, 39, "https://example.com/tokyo_tower_hotel_1.jpg" },
                    { 78, 39, "https://example.com/tokyo_tower_hotel_2.jpg" },
                    { 79, 40, "https://example.com/tower_view_inn_1.jpg" },
                    { 80, 40, "https://example.com/tower_view_inn_2.jpg" },
                    { 81, 41, "https://example.com/tokyo_stay_1.jpg" },
                    { 82, 41, "https://example.com/tokyo_stay_2.jpg" },
                    { 83, 42, "https://example.com/kyoto_palace_hotel_1.jpg" },
                    { 84, 42, "https://example.com/kyoto_palace_hotel_2.jpg" },
                    { 85, 43, "https://example.com/imperial_inn_1.jpg" },
                    { 86, 43, "https://example.com/imperial_inn_2.jpg" },
                    { 87, 44, "https://example.com/kyoto_stay_1.jpg" },
                    { 88, 44, "https://example.com/kyoto_stay_2.jpg" },
                    { 89, 45, "https://example.com/hiroshima_hotel_1.jpg" },
                    { 90, 45, "https://example.com/hiroshima_hotel_2.jpg" },
                    { 91, 46, "https://example.com/peace_inn_1.jpg" },
                    { 92, 46, "https://example.com/peace_inn_2.jpg" },
                    { 93, 47, "https://example.com/hiroshima_stay_1.jpg" },
                    { 94, 47, "https://example.com/hiroshima_stay_2.jpg" },
                    { 95, 48, "https://example.com/itsukushima_hotel_1.jpg" },
                    { 96, 48, "https://example.com/itsukushima_hotel_2.jpg" },
                    { 97, 49, "https://example.com/shrine_view_inn_1.jpg" },
                    { 98, 49, "https://example.com/shrine_view_inn_2.jpg" },
                    { 99, 50, "https://example.com/shrine_stay_1.jpg" },
                    { 100, 50, "https://example.com/shrine_stay_2.jpg" },
                    { 101, 51, "https://example.com/sydney_opera_hotel_1.jpg" },
                    { 102, 51, "https://example.com/sydney_opera_hotel_2.jpg" },
                    { 103, 52, "https://example.com/harbour_inn_1.jpg" },
                    { 104, 52, "https://example.com/harbour_inn_2.jpg" },
                    { 105, 53, "https://example.com/opera_stay_1.jpg" },
                    { 106, 53, "https://example.com/opera_stay_2.jpg" },
                    { 107, 54, "https://example.com/great_barrier_reef_hotel_1.jpg" },
                    { 108, 54, "https://example.com/great_barrier_reef_hotel_2.jpg" },
                    { 109, 55, "https://example.com/reef_inn_1.jpg" },
                    { 110, 55, "https://example.com/reef_inn_2.jpg" },
                    { 111, 56, "https://example.com/reef_stay_1.jpg" },
                    { 112, 56, "https://example.com/reef_stay_2.jpg" },
                    { 113, 57, "https://example.com/uluru_hotel_1.jpg" },
                    { 114, 57, "https://example.com/uluru_hotel_2.jpg" },
                    { 115, 58, "https://example.com/rock_inn_1.jpg" },
                    { 116, 58, "https://example.com/rock_inn_2.jpg" },
                    { 117, 59, "https://example.com/uluru_stay_1.jpg" },
                    { 118, 59, "https://example.com/uluru_stay_2.jpg" },
                    { 119, 60, "https://example.com/great_wall_hotel_1.jpg" },
                    { 120, 60, "https://example.com/great_wall_hotel_2.jpg" },
                    { 121, 61, "https://example.com/wall_view_inn_1.jpg" },
                    { 122, 61, "https://example.com/wall_view_inn_2.jpg" },
                    { 123, 62, "https://example.com/wall_stay_1.jpg" },
                    { 124, 62, "https://example.com/wall_stay_2.jpg" },
                    { 125, 63, "https://example.com/forbidden_city_hotel_1.jpg" },
                    { 126, 63, "https://example.com/forbidden_city_hotel_2.jpg" },
                    { 127, 64, "https://example.com/palace_inn_1.jpg" },
                    { 128, 64, "https://example.com/palace_inn_2.jpg" },
                    { 129, 65, "https://example.com/forbidden_stay_1.jpg" },
                    { 130, 65, "https://example.com/forbidden_stay_2.jpg" },
                    { 131, 66, "https://example.com/terracotta_warriors_hotel_1.jpg" },
                    { 132, 66, "https://example.com/terracotta_warriors_hotel_2.jpg" },
                    { 133, 67, "https://example.com/warrior_inn_1.jpg" },
                    { 134, 67, "https://example.com/warrior_inn_2.jpg" },
                    { 135, 68, "https://example.com/warrior_stay_1.jpg" },
                    { 136, 68, "https://example.com/warrior_stay_2.jpg" },
                    { 137, 69, "https://example.com/machu_picchu_hotel_1.jpg" },
                    { 138, 69, "https://example.com/machu_picchu_hotel_2.jpg" },
                    { 139, 70, "https://example.com/inca_inn_1.jpg" },
                    { 140, 70, "https://example.com/inca_inn_2.jpg" },
                    { 141, 71, "https://example.com/inca_stay_1.jpg" },
                    { 142, 71, "https://example.com/inca_stay_2.jpg" },
                    { 143, 72, "https://example.com/cusco_hotel_1.jpg" },
                    { 144, 72, "https://example.com/cusco_hotel_2.jpg" },
                    { 145, 73, "https://example.com/andes_inn_1.jpg" },
                    { 146, 73, "https://example.com/andes_inn_2.jpg" },
                    { 147, 74, "https://example.com/andes_stay_1.jpg" },
                    { 148, 74, "https://example.com/andes_stay_2.jpg" },
                    { 149, 75, "https://example.com/lake_titicaca_hotel_1.jpg" },
                    { 150, 75, "https://example.com/lake_titicaca_hotel_2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "attractionImages",
                columns: new[] { "Id", "AttractionId", "Url" },
                values: new object[,]
                {
                    { 3, 2, "Teste01" },
                    { 4, 2, "Teste02" },
                    { 5, 3, "Teste01" },
                    { 6, 3, "Teste02" },
                    { 7, 4, "Teste01" },
                    { 8, 4, "Teste02" },
                    { 9, 5, "Teste01" },
                    { 10, 5, "Teste02" },
                    { 11, 6, "Teste01" },
                    { 12, 6, "Teste02" },
                    { 13, 7, "Teste01" },
                    { 14, 7, "Teste02" },
                    { 15, 8, "Teste01" },
                    { 16, 8, "Teste02" },
                    { 17, 9, "Teste01" },
                    { 18, 9, "Teste02" },
                    { 19, 10, "Teste01" },
                    { 20, 10, "Teste02" },
                    { 21, 11, "Teste01" },
                    { 22, 11, "Teste02" },
                    { 23, 12, "Teste01" },
                    { 24, 12, "Teste02" },
                    { 25, 13, "Teste01" },
                    { 26, 13, "Teste02" },
                    { 27, 14, "Teste01" },
                    { 28, 14, "Teste02" },
                    { 29, 15, "Teste01" },
                    { 30, 15, "Teste02" },
                    { 31, 16, "Teste01" },
                    { 32, 16, "Teste02" },
                    { 33, 17, "Teste01" },
                    { 34, 17, "Teste02" },
                    { 35, 18, "Teste01" },
                    { 36, 18, "Teste02" },
                    { 37, 19, "Teste01" },
                    { 38, 19, "Teste02" },
                    { 39, 20, "Teste01" },
                    { 40, 20, "Teste02" },
                    { 41, 21, "Teste01" },
                    { 42, 21, "Teste02" },
                    { 43, 22, "Teste01" },
                    { 44, 22, "Teste02" },
                    { 45, 23, "Teste01" },
                    { 46, 23, "Teste02" },
                    { 47, 24, "Teste01" },
                    { 48, 24, "Teste02" },
                    { 49, 25, "Teste01" },
                    { 50, 25, "Teste02" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "accommodationImages",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Accommodations",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.RenameColumn(
                name: "AttractionId",
                table: "Accommodations",
                newName: "AttractiondId");
        }
    }
}
