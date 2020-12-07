using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolutions.Data.Migrations
{
    public partial class ChangeFileLengthType2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 8, 3, 3, 2, 65, DateTimeKind.Local).AddTicks(9956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 7, 22, 10, 32, 405, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("09c6650e-e546-47a8-83c9-334288cbf890"),
                column: "ConcurrencyStamp",
                value: "922d0779-3c2e-4433-9a0a-a7435966b521");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8ff90397-f7d3-4f97-8efe-d563682f7c29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6872b4fb-be71-4658-afa8-a2dd382e67bc", "AQAAAAEAACcQAAAAEFxcWYy2ByJuDtsELzQtMBRQQnrvZsLr3nu/qczE3p/89eDYcPdNpV+JMuCY3z9pNQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 8, 3, 3, 2, 87, DateTimeKind.Local).AddTicks(6921));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 22, 10, 32, 405, DateTimeKind.Local).AddTicks(2759),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 8, 3, 3, 2, 65, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("09c6650e-e546-47a8-83c9-334288cbf890"),
                column: "ConcurrencyStamp",
                value: "31315c4a-9291-4003-a898-b600e13ccaf5");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8ff90397-f7d3-4f97-8efe-d563682f7c29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a5c2c0b0-7b26-4aa2-a0e2-5050754e2e48", "AQAAAAEAACcQAAAAECKhRSmM5c3C1RiMRLipviTML+2F1gkBAgxE+L5KiAYsh5PGb89Y/UmzCfTz+LNxig==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 7, 22, 10, 32, 425, DateTimeKind.Local).AddTicks(2671));
        }
    }
}
