using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolutions.Data.Migrations
{
    public partial class AddProductImagesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 20, 12, 57, 165, DateTimeKind.Local).AddTicks(8429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 4, 2, 33, 14, 157, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 4, 2, 33, 14, 157, DateTimeKind.Local).AddTicks(9906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 7, 20, 12, 57, 165, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("09c6650e-e546-47a8-83c9-334288cbf890"),
                column: "ConcurrencyStamp",
                value: "f1945b63-8a14-4bf5-aac1-749b1768d466");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8ff90397-f7d3-4f97-8efe-d563682f7c29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1b08dad0-69ef-43f1-b143-2bc2cb435761", "AQAAAAEAACcQAAAAEGuN/F+tBTufilOjU1zfBzg2sGvAQX+Nl0aD8nTkMkdFGXXUzuJZinWKgBZ9MB0+yw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 2, 33, 14, 176, DateTimeKind.Local).AddTicks(3627));
        }
    }
}
