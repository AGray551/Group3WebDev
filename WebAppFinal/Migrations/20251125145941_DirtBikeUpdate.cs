using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppFinal.Migrations
{
    /// <inheritdoc />
    public partial class DirtBikeUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "DirtBikes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "DirtBikes",
                keyColumn: "DirtBikeId",
                keyValue: 1,
                columns: new[] { "Description", "Displacement", "Model", "Year" },
                values: new object[] { "This was my first introduction to dirt bikes, I have great memories of riding this bike around my parents front yard. They probably didn't like all the tracks it left in the yard.", "80cc", "CR80", "1998" });

            migrationBuilder.UpdateData(
                table: "DirtBikes",
                keyColumn: "DirtBikeId",
                keyValue: 2,
                columns: new[] { "Description", "Displacement", "Make", "Model" },
                values: new object[] { "My second bike. This one was not as thrilling as the previous. CR80, but my CR80 ended up blowing up and at the time, I didn't have the knowledge or funds to repair it. The XR100 was still a good bike, but I was beginning to get too big for it.", "100cc", "Honda", "XR100" });

            migrationBuilder.UpdateData(
                table: "DirtBikes",
                keyColumn: "DirtBikeId",
                keyValue: 3,
                columns: new[] { "Description", "Displacement", "Make", "Model", "Year" },
                values: new object[] { "This was my first 'full size' bike. This bike had much more power than the previous XR100, but it wasn't crazy fast by any means. I was just happy to have a bigger bike at this point.", "200cc", "Honda", "XR200", "2002" });

            migrationBuilder.InsertData(
                table: "DirtBikes",
                columns: new[] { "DirtBikeId", "Description", "Displacement", "Make", "Model", "Year" },
                values: new object[,]
                {
                    { 4, "This bike was a step up from the XR200, but for whatever reason it wasn't very reliable so I ended up selling it pretty quickly.", "250cc", "Honda", "XR250R", "1999" },
                    { 5, "This bike was very fun but it didn't have much torque which became a problem since I mostly rode it in areas with steep hills and tight trails.", "125cc", "Honda", "CR125", "2001" },
                    { 6, "This my first 'Fast' bike. I had a lot of fun on it but it wasn't in the best shape when I bought it so it didn't last long before it started having issues.", "250cc", "Kawasaki", "KX250", "1999" },
                    { 7, "My current bike. I purchased it from a guy that took great care of it and it runs great. I've had it for 4 years now and it's never let me down. I plan to keep this bike for a long time and rebuild it when the time comes.", "250cc", "Yamaha", "YZ250", "2004" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DirtBikes",
                keyColumn: "DirtBikeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DirtBikes",
                keyColumn: "DirtBikeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DirtBikes",
                keyColumn: "DirtBikeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DirtBikes",
                keyColumn: "DirtBikeId",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "DirtBikes");

            migrationBuilder.UpdateData(
                table: "DirtBikes",
                keyColumn: "DirtBikeId",
                keyValue: 1,
                columns: new[] { "Displacement", "Model", "Year" },
                values: new object[] { "249cc", "CR250", "1995" });

            migrationBuilder.UpdateData(
                table: "DirtBikes",
                keyColumn: "DirtBikeId",
                keyValue: 2,
                columns: new[] { "Displacement", "Make", "Model" },
                values: new object[] { "249cc", "Yamaha", "YZ250" });

            migrationBuilder.UpdateData(
                table: "DirtBikes",
                keyColumn: "DirtBikeId",
                keyValue: 3,
                columns: new[] { "Displacement", "Make", "Model", "Year" },
                values: new object[] { "249cc", "Suzuki", "RM250", "1999" });
        }
    }
}
