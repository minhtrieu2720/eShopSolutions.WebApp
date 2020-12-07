using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolutions.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 22, 10, 32, 405, DateTimeKind.Local).AddTicks(2759),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 7, 20, 12, 57, 165, DateTimeKind.Local).AddTicks(8429));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 20, 12, 57, 165, DateTimeKind.Local).AddTicks(8429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 7, 22, 10, 32, 405, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("09c6650e-e546-47a8-83c9-334288cbf890"),
                column: "ConcurrencyStamp",
                value: "317da137-ceca-40b9-9bd4-0e46ef43a2a2");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8ff90397-f7d3-4f97-8efe-d563682f7c29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77abe6d5-b87c-4679-bbd6-a88715fdf429", "AQAAAAEAACcQAAAAELVoGjvrSuX7TJDah7kxX3IbUsqZQxa8tl7YN91aaHXQbfSGPZnGAbK/2ZvEWOYB+w==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 7, 20, 12, 57, 185, DateTimeKind.Local).AddTicks(8632));
        }
    }
}
