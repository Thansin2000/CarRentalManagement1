using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement1.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c0d6768-818a-4eab-af32-3ee40419f3ea", "AQAAAAIAAYagAAAAEOFJrGMj6VzlM2pWUiUrhFNrp5IbSVWQgcbYsOu2L61CXZ3st3Yn6K0eti2WIIVXlQ==", "cae7eaca-9f68-4794-98c5-ad5f45829c9d" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 19, 9, 213, DateTimeKind.Local).AddTicks(6389), new DateTime(2026, 2, 8, 20, 19, 9, 213, DateTimeKind.Local).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 19, 9, 213, DateTimeKind.Local).AddTicks(6404), new DateTime(2026, 2, 8, 20, 19, 9, 213, DateTimeKind.Local).AddTicks(6405) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 19, 9, 213, DateTimeKind.Local).AddTicks(6561), new DateTime(2026, 2, 8, 20, 19, 9, 213, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 19, 9, 213, DateTimeKind.Local).AddTicks(6563), new DateTime(2026, 2, 8, 20, 19, 9, 213, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 19, 9, 213, DateTimeKind.Local).AddTicks(6629), new DateTime(2026, 2, 8, 20, 19, 9, 213, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 19, 9, 213, DateTimeKind.Local).AddTicks(6631), new DateTime(2026, 2, 8, 20, 19, 9, 213, DateTimeKind.Local).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 19, 9, 213, DateTimeKind.Local).AddTicks(6632), new DateTime(2026, 2, 8, 20, 19, 9, 213, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 19, 9, 213, DateTimeKind.Local).AddTicks(6634), new DateTime(2026, 2, 8, 20, 19, 9, 213, DateTimeKind.Local).AddTicks(6634) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
