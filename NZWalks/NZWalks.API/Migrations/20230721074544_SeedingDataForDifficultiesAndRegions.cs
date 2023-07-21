using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataForDifficultiesAndRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Difficultys");

            migrationBuilder.DropColumn(
                name: "RegionImageUrl",
                table: "Difficultys");

            migrationBuilder.InsertData(
                table: "Difficultys",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1efcd22a-e209-4ac0-9fd7-ccc976791fc9"), "Hard" },
                    { new Guid("8f0c279d-89ce-4a1c-b113-b9031b22dfef"), "Medium" },
                    { new Guid("acf1976e-98eb-4ba3-a738-3a697f58cac1"), "Easy" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("0ca1d8df-1c14-4268-8537-68ed6c3e4081"), "NSN", "Nelson", "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("2f28018d-778f-4a7f-9ceb-7138f92f7ffa"), "AKL", "Auckland", "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("52010945-9ce6-4b72-bf2c-24b4fece7e4f"), "STL", "Southland", null },
                    { new Guid("52bf972d-4a7f-47df-adc1-07bc95b6959e"), "WGN", "Wellington", "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("98fb4423-4be6-4117-b13d-db769915fc50"), "NTL", "Northland", null },
                    { new Guid("e06c161e-d225-47d6-a552-4e3e7d84b37d"), "BOP", "Bay Of Plenty", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficultys",
                keyColumn: "Id",
                keyValue: new Guid("1efcd22a-e209-4ac0-9fd7-ccc976791fc9"));

            migrationBuilder.DeleteData(
                table: "Difficultys",
                keyColumn: "Id",
                keyValue: new Guid("8f0c279d-89ce-4a1c-b113-b9031b22dfef"));

            migrationBuilder.DeleteData(
                table: "Difficultys",
                keyColumn: "Id",
                keyValue: new Guid("acf1976e-98eb-4ba3-a738-3a697f58cac1"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("0ca1d8df-1c14-4268-8537-68ed6c3e4081"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2f28018d-778f-4a7f-9ceb-7138f92f7ffa"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("52010945-9ce6-4b72-bf2c-24b4fece7e4f"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("52bf972d-4a7f-47df-adc1-07bc95b6959e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("98fb4423-4be6-4117-b13d-db769915fc50"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("e06c161e-d225-47d6-a552-4e3e7d84b37d"));

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Difficultys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RegionImageUrl",
                table: "Difficultys",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
