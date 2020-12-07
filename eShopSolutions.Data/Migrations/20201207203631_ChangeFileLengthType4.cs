using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolutions.Data.Migrations
{
    public partial class ChangeFileLengthType4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dob",
                table: "AppUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 8, 3, 36, 30, 457, DateTimeKind.Local).AddTicks(785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 8, 3, 3, 2, 65, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("09c6650e-e546-47a8-83c9-334288cbf890"),
                column: "ConcurrencyStamp",
                value: "242e2667-b12d-4d24-8855-6cf283fa28d9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8ff90397-f7d3-4f97-8efe-d563682f7c29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ac6afc4-e9a1-4eb4-a1a8-098a7a7b3479", "AQAAAAEAACcQAAAAEEd6iZ1riwfjVZ+ZKIq5EdvpkqJ4E/QUbqCdu8O9UgrdIN7usRudmIjmoViH+RqLJw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 8, 3, 36, 30, 476, DateTimeKind.Local).AddTicks(9703));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 8, 3, 3, 2, 65, DateTimeKind.Local).AddTicks(9956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 8, 3, 36, 30, 457, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.AddColumn<DateTime>(
                name: "Dob",
                table: "AppUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                columns: new[] { "ConcurrencyStamp", "Dob", "PasswordHash" },
                values: new object[] { "6872b4fb-be71-4658-afa8-a2dd382e67bc", new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEFxcWYy2ByJuDtsELzQtMBRQQnrvZsLr3nu/qczE3p/89eDYcPdNpV+JMuCY3z9pNQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 8, 3, 3, 2, 87, DateTimeKind.Local).AddTicks(6921));
        }
    }
}
