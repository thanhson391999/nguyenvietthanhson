using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("68daf1e5-a756-47f6-9cb4-69eae8f79c8c"),
                column: "ConcurrencyStamp",
                value: "72096555-fbea-4149-b10b-fda438bbafda");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d65c36fe-187b-4d17-aa33-41c9ea0dbcac"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "83d2dffb-b900-4811-a907-a2b88c3b2829", "AQAAAAEAACcQAAAAEJNqRtWmQID8uUPWTmKt6SQP7prTbOjR1K0ZoHNyePWXdpfVVE6xX9Wqe0EP1TWPqw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 25, 17, 33, 54, 14, DateTimeKind.Local).AddTicks(4752));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

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
        }
    }
}
