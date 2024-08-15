using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourTrack.Api.Migrations
{
    /// <inheritdoc />
    public partial class Teste07 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "attractionImages",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CountryName", "Description", "EntryFee", "Name", "OpeningHours" },
                values: new object[] { "Bennelong Point, Sydney NSW 2000, Australia", "One of the most iconic buildings in the world – the Sydney Opera House is an architectural masterpiece and vibrant performance space. It's a place where the past shapes the future, where conventions are challenged and cultures are celebrated. Step inside and discover the stories that make the Opera House so inspiring. Whether you’re a local or a tourist, a first-timer or an aficionado, the Sydney Opera House has something for everyone.", "₹2,520.24", "Sydeney Opera House", "8:45 AM - 5:00 PM" });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CountryId", "Description", "Name" },
                values: new object[] { 5, "Manly Beach is a beach situated among the Northern Beaches of Sydney, Australia, in Manly, New South Wales. From north to south, the three main sections are Queenscliff, North Steyne, and South Steyne", "Manly Beach" });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CountryId", "CountryName", "Description", "EntryFee", "Name", "OpeningHours" },
                values: new object[] { 5, "Melbourne VIC 3004, Australia", "Royal Botanic Gardens Victoria are botanic gardens across two sites–Melbourne and Cranbourne. Melbourne Gardens was founded in 1846 when land was reserved on the south side of the Yarra River for a new botanic garden. It extends across 38 hectares that slope to the river with trees, garden beds, lakes and lawns.", "A$32.00", "Royal Botanic Gardens Victoria - Melbourne Gardens", "7:30 AM–5:30 PM" });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CountryId", "CountryName", "Description", "EntryFee", "Name", "OpeningHours" },
                values: new object[] { 5, "Bradleys Head Rd, Mosman NSW 2088, Australia", "Taronga Zoo is a government-run public zoo located in Sydney, New South Wales, Australia, in the suburb of Mosman, on the shores of Sydney Harbour. The opening hours are between 9:30 a.m. to 4:30 p.m. Taronga is an Aboriginal word meaning \"beautiful view\". It was officially opened on 7 October 1916.", "$105.60", "Taronga Zoo Sydney", "09:30" });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "EntryFee", "Name", "OpeningHours" },
                values: new object[] { "Playground swings available · Has skateboarding area\r\nThe South Bank Parklands are located at South Bank within the suburb of South Brisbane in Brisbane, Queensland, Australia. The parkland, on the transformed site of Brisbane's World Expo 88, was officially opened to the public on 20 June 1992", "Free", "South Bank Parklands", "05:30AM - 12:00AM" });

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Url",
                value: "https://www.google.com/imgres?q=torre%20eiffel&imgurl=https%3A%2F%2Fimgmd.net%2Fimages%2Fv1%2Fguia%2F1704562%2Ftorre-eiffel.jpg&imgrefurl=https%3A%2F%2Fguia.melhoresdestinos.com.br%2Ftorre-eiffel-paris.html&docid=gIzbt_dOewPWdM&tbnid=u_MFMaN5pvm6QM&vet=12ahUKEwjtjILejuOHAxU4q5UCHbe-FwMQM3oECCIQAA..i&w=2400&h=1600&hcb=2&ved=2ahUKEwjtjILejuOHAxU4q5UCHbe-FwMQM3oECCIQAA");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "https://www.voupranos.com.br/wp-content/uploads/2022/09/AdobeStock_44313077-1024x683.jpeg");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Url",
                value: "https://res.cloudinary.com/du5jifpgg/image/upload/t_opengraph_image/Surcharge-APIDAE/Musee_du_Louvre_ete-2023.jpg");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Url",
                value: "https://www.google.com/imgres?q=louvre%20museum&imgurl=https%3A%2F%2Fcdn.sortiraparis.com%2Fimages%2F80%2F103941%2F973572-visuels-musee-du-louvre.jpg&imgrefurl=https%3A%2F%2Fwww.sortiraparis.com%2Fen%2Fwhat-to-visit-in-paris%2Fexhibit-museum%2Farticles%2F1188-musee-du-louvre-discover-the-artistic-and-tourist-heart-of-the-capital&docid=kXqla4BgkWIkEM&tbnid=yPFl7K1aNrY38M&vet=12ahUKEwjj0s3ij-OHAxUcq5UCHZ9uKNUQM3oECFgQAA..i&w=1600&h=1200&hcb=2&ved=2ahUKEwjj0s3ij-OHAxUcq5UCHZ9uKNUQM3oECFgQAA");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Url",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSc1Ni2tOFudZKoGf_Ax-tPf4qOk8nlE0IOGQ&s");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Url",
                value: "https://images.a12.com/source/files/c/285234/Palacio_de_Versalhes_-_Franca-933495_1000-669-0-0.jpg");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Url",
                value: "https://en.normandie-tourisme.fr/wp-content/uploads/sites/3/2023/07/baie-mont-saint-michel-de-nuit-marc-lerouge-1200x800.jpg");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "Url",
                value: "https://en.normandie-tourisme.fr/wp-content/uploads/sites/3/2020/01/8118-Mont-Saint-Michel-couleur-dautomne-%C2%A9-DaLiu-Shutterstock.com-%C2%A9-DaLiu-Shutterstock.com_.jpg");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "Url",
                value: "https://cdn.britannica.com/27/250127-050-A95F35DE/Chateaude-Chambord.jpg");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "Url",
                value: "https://www.historyhit.com/app/uploads/2020/11/Chateau-de-Chambord.jpg");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipNyb9QfYZ6QqZflHC2eoCqyhjNKOmRrvlCHeCmq=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipP4VxoUVCQIUUqSqKAB2qX_nWaRZgy1WkjxgM5s=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipNOkjsKcMBL_Fia95bCQvwISPZBNG_Addfw3AYm=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipNw_9BgocIVd5ukJqRx86w7KG_6BxMsJfNncvTm=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipNSLBiQHaYCKNDCLcdbWxth_4uJMggdvT8bXwLt=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipN4fq7cy0SSffufDFsZgurz0BvF2RLMc4QvnmRk=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipMfwcz2feEkN1CXLkhQxnwU3kUYO8rL1R4PBPX2=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipMkdB67tOCrTPHUzDH4UuBx6pcf6Wna5Y0htqDt=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipN0-mJ4M1ftzod1vtrdwMyE2fmmqxGdPxnvQMH4=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipNUPAS5i4G9UsOnKyz8oUAZIhYUlaUrre3fjzqR=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipO0jDqEA4d2y-H9bcfOJ3NgTPhpbdFNFdwB3eZu=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipM1Pzbc3Wy6NPD7hqH0ILX5MpsrfAB-6S9koOR2=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "Url",
                value: "https://as1.ftcdn.net/v2/jpg/02/99/91/98/1000_F_299919821_Ege4s2w90kGGCi4fAsVg4zYW1BMkxqh2.jpg");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "Url",
                value: "https://www.exp1.com/blog/wp-content/uploads/sites/7/2018/03/venice1.jpeg");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipNCVdTcDJAScCRhWktcizQUxYrlj59Ywhv44uKw=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "Url",
                value: "https://www.enflorencia.com/wp-content/uploads/2022/03/Torre-de-Pisa-scaled.webp");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipOBv4OY707Q1jUpkUW_lu4MRv75ri3B_fxG-rA=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipOrHczOFXzZyn9DN5-L4TZ9ucl_l4iOD0ZkRZ7g=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipO286FrRLq_CeLxc7kXGz7jFaw-tmr4iuzg9f80=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipPocgU4qhUz3nmr4eDGvP3Ya8Q4kCzwuwICdGiT=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "Url",
                value: "https://www.civitatis.com/f/japon/tokio/galeria/paisajes-naturales-monte-fuji.jpg");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "Url",
                value: "https://www.civitatis.com/f/japon/tokio/galeria/paisajes-teleferico-monte-fuji.jpg");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipNu6PXxGUoernEhHtqgVTj09KL_phSgcd5fSmRa=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipNbX92cBVxHt3bQny0lEiihty0Vt3L5L7AwEUu6=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipMLiaP8rTF2qRPZawoGtnsu6l3Pjdwr4RQ-SpFg=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "Url",
                value: "https://lh5.googleusercontent.com/p/AF1QipOuG4AaBIUaysro0dIGGGev-Nz8EEv80k-7bgGl=w243-h174-n-k-no-nu");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipNepH_nHqXcBDXVZcFZpRAUrlgHoPPJch2pYjtI=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "Url",
                value: "https://lh5.googleusercontent.com/p/AF1QipOtLAXkX8CSYQ5jJ8vDZ8bGYF8I3djt1IXyntFB=w243-h174-n-k-no-nu");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipNPX7gPFv9Zgo5bBDPQxPcsDGNjtDFYLHQPaM1d=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipMxZlKoltgRKXSPwNMtOLBXqj4d9nTQ8t542bhC=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipMHftgSCBlvyjxYphi4gLqDC_62WWvZvyy1EBuh=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipPDW7FdkZAvBUhIGwbp63Ar10n22mJzlywhGFBS=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "Url",
                value: "https://t2.gstatic.com/licensed-image?q=tbn:ANd9GcT7TTlnBvYx42VGhXrI2ob9SfHnluzh5yrfQPPNLKI92pdQEG8hDIQ2gAsQZiEh7aVH");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "Url",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT0Go-UrkIHVs6oAFZObJq_8LmoG3H8dD9eqQ&s");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipNr16xQjl9PqqLfiXee9kHtLv7xu-kvjiBPdeWw=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipOyIYnnHeQ08pfHozIDPedVmJBWabC8xjPy_G0-=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "Url",
                value: "https://lh5.googleusercontent.com/p/AF1QipPbVZakieiHTyFgD6K9nkC3bXaduMLl3AlR60yo=w341-h256-k-no");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipOdXc26iy6hvOoqUcNWsjQ77kelgUzH6GvpWgZM=s680-w680-h510-rw");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipNzQ9NmpdFMhGYxWz0AJCv9fxwJjEq4seRiax-z=s680-w680-h510");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "Url",
                value: "https://lh3.googleusercontent.com/p/AF1QipP97SP8D3Kdk04f11uls9gPHDfQ58KYYVjHEKyo=s680-w680-h510");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "attractionImages",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CountryName", "Description", "EntryFee", "Name", "OpeningHours" },
                values: new object[] { "Art Museum, Paris, France", "An iconic volcano and highest peak in Japan.", "¥1000", "Mount Fuji", "24 hours" });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CountryId", "Description", "Name" },
                values: new object[] { 4, "An iconic communications and observation tower in Tokyo.", "Tokyo Tower" });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CountryId", "CountryName", "Description", "EntryFee", "Name", "OpeningHours" },
                values: new object[] { 4, "Art Museum, Paris, France", "Former ruling palace of the Emperor of Japan.", "Free", "Kyoto Imperial Palace", "09:00 - 17:00" });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CountryId", "CountryName", "Description", "EntryFee", "Name", "OpeningHours" },
                values: new object[] { 4, "Art Museum, Paris, France", "A memorial park in Hiroshima, dedicated to the legacy of atomic bombing.", "¥200", "Hiroshima Peace Memorial", "08:30 - 18:00" });

            migrationBuilder.UpdateData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "EntryFee", "Name", "OpeningHours" },
                values: new object[] { "A Shinto shrine on the island of Itsukushima, known for its 'floating' torii gate.", "¥300", "Itsukushima Shrine", "06:30 - 18:00" });

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "Url",
                value: "Teste02");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "Url",
                value: "Teste01");

            migrationBuilder.UpdateData(
                table: "attractionImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "Url",
                value: "Teste02");
        }
    }
}
