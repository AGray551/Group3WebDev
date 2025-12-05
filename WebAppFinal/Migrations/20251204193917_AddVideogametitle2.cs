using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppFinal.Migrations
{
    /// <inheritdoc />
    public partial class AddVideogametitle2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 1,
                column: "Title",
                value: "Mario 64");

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 2,
                columns: new[] { "Genre", "Platforms", "Rating", "ReleaseDate", "Title" },
                values: new object[] { "Action", "PS2, PC", 4.5, new DateTime(2005, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Devil May Cry 3" });

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "VideoGameId", "Genre", "Platforms", "Rating", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 3, "Puzzle", "PC, PS3, Xbox 360", 5.0, new DateTime(2011, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portal 2" },
                    { 4, "RPG", "PC, PS4, PS5, Xbox One", 4.7999999999999998, new DateTime(2019, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Disco Elysium" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 1,
                column: "Title",
                value: null);

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "VideoGameId",
                keyValue: 2,
                columns: new[] { "Genre", "Platforms", "Rating", "ReleaseDate", "Title" },
                values: new object[] { "Platformer", "PC", 5.0, new DateTime(2011, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }
    }
}
