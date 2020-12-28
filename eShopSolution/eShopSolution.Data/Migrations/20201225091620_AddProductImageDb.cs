using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 23, 17, 13, 30, 582, DateTimeKind.Local).AddTicks(9370));

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
                    FileSize = table.Column<int>(type: "int", nullable: false)
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
                keyValue: new Guid("68daf1e5-a756-47f6-9cb4-69eae8f79c8c"),
                column: "ConcurrencyStamp",
                value: "6c185d2f-37d8-4d9f-8d19-120626322066");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d65c36fe-187b-4d17-aa33-41c9ea0dbcac"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79467f22-feb3-4b26-ac51-c9d7e3357190", "AQAAAAEAACcQAAAAENA75h8fhJijTegGTuvr3WPHyPnps4CdtJ7GSPYnrNK9of9YMU5ZKYvmNd6BdTxUWQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 25, 16, 16, 18, 291, DateTimeKind.Local).AddTicks(8649));

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
                defaultValue: new DateTime(2020, 12, 23, 17, 13, 30, 582, DateTimeKind.Local).AddTicks(9370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("68daf1e5-a756-47f6-9cb4-69eae8f79c8c"),
                column: "ConcurrencyStamp",
                value: "d30a7cc6-9db2-44f6-a330-9bfbf324779d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d65c36fe-187b-4d17-aa33-41c9ea0dbcac"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc781774-dd1b-4bde-a0fe-b2623c6d3ae2", "AQAAAAEAACcQAAAAED7ZqkGBkrnl2Ikb9vFBj8EVORrFqxDKQZ8o/IPh8QxMZHYb2KBHjt9q2alUUEC5qA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 23, 17, 13, 30, 620, DateTimeKind.Local).AddTicks(286));
        }
    }
}
