using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement1.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 15, 51, 25, 270, DateTimeKind.Local).AddTicks(7550), new DateTime(2026, 2, 8, 15, 51, 25, 270, DateTimeKind.Local).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 15, 51, 25, 270, DateTimeKind.Local).AddTicks(7580), new DateTime(2026, 2, 8, 15, 51, 25, 270, DateTimeKind.Local).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 15, 51, 25, 270, DateTimeKind.Local).AddTicks(7968), new DateTime(2026, 2, 8, 15, 51, 25, 270, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 15, 51, 25, 270, DateTimeKind.Local).AddTicks(7971), new DateTime(2026, 2, 8, 15, 51, 25, 270, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 15, 51, 25, 270, DateTimeKind.Local).AddTicks(8097), new DateTime(2026, 2, 8, 15, 51, 25, 270, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 15, 51, 25, 270, DateTimeKind.Local).AddTicks(8100), new DateTime(2026, 2, 8, 15, 51, 25, 270, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 15, 51, 25, 270, DateTimeKind.Local).AddTicks(8102), new DateTime(2026, 2, 8, 15, 51, 25, 270, DateTimeKind.Local).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 15, 51, 25, 270, DateTimeKind.Local).AddTicks(8104), new DateTime(2026, 2, 8, 15, 51, 25, 270, DateTimeKind.Local).AddTicks(8105) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 15, 50, 50, 697, DateTimeKind.Local).AddTicks(7399), new DateTime(2026, 2, 8, 15, 50, 50, 697, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 15, 50, 50, 697, DateTimeKind.Local).AddTicks(7416), new DateTime(2026, 2, 8, 15, 50, 50, 697, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 15, 50, 50, 697, DateTimeKind.Local).AddTicks(7677), new DateTime(2026, 2, 8, 15, 50, 50, 697, DateTimeKind.Local).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 15, 50, 50, 697, DateTimeKind.Local).AddTicks(7680), new DateTime(2026, 2, 8, 15, 50, 50, 697, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 15, 50, 50, 697, DateTimeKind.Local).AddTicks(7797), new DateTime(2026, 2, 8, 15, 50, 50, 697, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 15, 50, 50, 697, DateTimeKind.Local).AddTicks(7799), new DateTime(2026, 2, 8, 15, 50, 50, 697, DateTimeKind.Local).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 15, 50, 50, 697, DateTimeKind.Local).AddTicks(7801), new DateTime(2026, 2, 8, 15, 50, 50, 697, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 15, 50, 50, 697, DateTimeKind.Local).AddTicks(7802), new DateTime(2026, 2, 8, 15, 50, 50, 697, DateTimeKind.Local).AddTicks(7803) });
        }
    }
}
