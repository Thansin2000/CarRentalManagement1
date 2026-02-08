using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement1.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f7cc153-3ee8-4ec9-922f-8dd602914d72", "AQAAAAIAAYagAAAAEMt4nPcRTpSc8siZs/JZ/1J9ActVi+alvbCWTkqbsO5/RzbgZr9Ucm3QgthyVnBzwQ==", "26242524-76a1-485c-8549-62690b10543f" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 19, 41, 73, DateTimeKind.Local).AddTicks(8990), new DateTime(2026, 2, 8, 20, 19, 41, 73, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 19, 41, 73, DateTimeKind.Local).AddTicks(9006), new DateTime(2026, 2, 8, 20, 19, 41, 73, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 19, 41, 73, DateTimeKind.Local).AddTicks(9201), new DateTime(2026, 2, 8, 20, 19, 41, 73, DateTimeKind.Local).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 19, 41, 73, DateTimeKind.Local).AddTicks(9204), new DateTime(2026, 2, 8, 20, 19, 41, 73, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 19, 41, 73, DateTimeKind.Local).AddTicks(9287), new DateTime(2026, 2, 8, 20, 19, 41, 73, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 19, 41, 73, DateTimeKind.Local).AddTicks(9290), new DateTime(2026, 2, 8, 20, 19, 41, 73, DateTimeKind.Local).AddTicks(9291) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 19, 41, 73, DateTimeKind.Local).AddTicks(9292), new DateTime(2026, 2, 8, 20, 19, 41, 73, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 2, 8, 20, 19, 41, 73, DateTimeKind.Local).AddTicks(9294), new DateTime(2026, 2, 8, 20, 19, 41, 73, DateTimeKind.Local).AddTicks(9294) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
