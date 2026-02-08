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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d07540b3-fe13-4e58-b5c0-7933a91363fe", "AQAAAAIAAYagAAAAEF+ClOANG49qKWYTpnTTuNiDD5mMwbUbdVkvOKinOC1Jv8f+IxlBJRLgduxZR+2nLg==", "aa205699-2f77-490f-b75e-491a419b1215" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 18, 2, 309, DateTimeKind.Local).AddTicks(1211), new DateTime(2026, 2, 8, 20, 18, 2, 309, DateTimeKind.Local).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 18, 2, 309, DateTimeKind.Local).AddTicks(1230), new DateTime(2026, 2, 8, 20, 18, 2, 309, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 18, 2, 309, DateTimeKind.Local).AddTicks(1466), new DateTime(2026, 2, 8, 20, 18, 2, 309, DateTimeKind.Local).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 18, 2, 309, DateTimeKind.Local).AddTicks(1469), new DateTime(2026, 2, 8, 20, 18, 2, 309, DateTimeKind.Local).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 18, 2, 309, DateTimeKind.Local).AddTicks(1559), new DateTime(2026, 2, 8, 20, 18, 2, 309, DateTimeKind.Local).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 18, 2, 309, DateTimeKind.Local).AddTicks(1561), new DateTime(2026, 2, 8, 20, 18, 2, 309, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 18, 2, 309, DateTimeKind.Local).AddTicks(1563), new DateTime(2026, 2, 8, 20, 18, 2, 309, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 18, 2, 309, DateTimeKind.Local).AddTicks(1565), new DateTime(2026, 2, 8, 20, 18, 2, 309, DateTimeKind.Local).AddTicks(1565) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7a20f34-4157-4b1a-8ebf-60024c26de9b", "AQAAAAIAAYagAAAAELJ3PLDXyYdcghsyTdF4O1XoaIVTTpnCe+hWK6s0Ca+iRTThggbvnLFbxMxy0fRp1Q==", "ec59c09d-e229-49f5-b0a4-5444de743f52" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 16, 35, 867, DateTimeKind.Local).AddTicks(5770), new DateTime(2026, 2, 8, 20, 16, 35, 867, DateTimeKind.Local).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 16, 35, 867, DateTimeKind.Local).AddTicks(5789), new DateTime(2026, 2, 8, 20, 16, 35, 867, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 16, 35, 867, DateTimeKind.Local).AddTicks(6075), new DateTime(2026, 2, 8, 20, 16, 35, 867, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 16, 35, 867, DateTimeKind.Local).AddTicks(6079), new DateTime(2026, 2, 8, 20, 16, 35, 867, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 16, 35, 867, DateTimeKind.Local).AddTicks(6181), new DateTime(2026, 2, 8, 20, 16, 35, 867, DateTimeKind.Local).AddTicks(6182) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 16, 35, 867, DateTimeKind.Local).AddTicks(6184), new DateTime(2026, 2, 8, 20, 16, 35, 867, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 16, 35, 867, DateTimeKind.Local).AddTicks(6185), new DateTime(2026, 2, 8, 20, 16, 35, 867, DateTimeKind.Local).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 16, 35, 867, DateTimeKind.Local).AddTicks(6187), new DateTime(2026, 2, 8, 20, 16, 35, 867, DateTimeKind.Local).AddTicks(6187) });
        }
    }
}
