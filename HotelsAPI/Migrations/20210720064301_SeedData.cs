using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelsAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { new Guid("78922a34-c905-4b96-ad7f-8261370a00db"), "Nigeria", "NG" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { new Guid("c9524b8d-bb98-422e-bcae-d291fbf88823"), "Ghana", "GH" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { new Guid("bf1363dd-c98e-4707-a041-1a08dd7df6b7"), "South Africa", "RSA" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78922a34-c905-4b96-ad7f-8261370a00db"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf1363dd-c98e-4707-a041-1a08dd7df6b7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c9524b8d-bb98-422e-bcae-d291fbf88823"));
        }
    }
}
