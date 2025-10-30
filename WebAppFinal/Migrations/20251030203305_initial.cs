using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppFinal.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DirtBikes",
                columns: table => new
                {
                    DirtBikeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Displacement = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirtBikes", x => x.DirtBikeId);
                });

            migrationBuilder.CreateTable(
                name: "DistanceRunnings",
                columns: table => new
                {
                    DistanceRunningId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Distance = table.Column<double>(type: "float", nullable: false),
                    Time = table.Column<int>(type: "int", nullable: false),
                    MaxHeartRate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistanceRunnings", x => x.DistanceRunningId);
                });

            migrationBuilder.CreateTable(
                name: "VideoGames",
                columns: table => new
                {
                    VideoGameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Platforms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGames", x => x.VideoGameId);
                });

            migrationBuilder.InsertData(
                table: "DirtBikes",
                columns: new[] { "DirtBikeId", "Displacement", "Make", "Model", "Year" },
                values: new object[,]
                {
                    { 1, "249cc", "Honda", "CR250", "1995" },
                    { 2, "249cc", "Yamaha", "YZ250", "2004" },
                    { 3, "249cc", "Suzuki", "RM250", "1999" }
                });

            migrationBuilder.InsertData(
                table: "DistanceRunnings",
                columns: new[] { "DistanceRunningId", "Date", "Distance", "MaxHeartRate", "Time" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.2000000000000002, 165, 45 },
                    { 2, new DateTime(2025, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.5, 172, 72 },
                    { 3, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0, 178, 88 },
                    { 4, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.7999999999999998, 168, 58 },
                    { 5, new DateTime(2025, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.0, 180, 105 }
                });

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "VideoGameId", "Genre", "Platforms", "Rating", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Platformer", "Nintendo 64", 3.5, new DateTime(1996, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Platformer", "PC", 5.0, new DateTime(2011, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DirtBikes");

            migrationBuilder.DropTable(
                name: "DistanceRunnings");

            migrationBuilder.DropTable(
                name: "VideoGames");
        }
    }
}
