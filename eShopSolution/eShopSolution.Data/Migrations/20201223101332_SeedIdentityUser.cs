using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 23, 17, 13, 30, 582, DateTimeKind.Local).AddTicks(9370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 23, 16, 52, 47, 263, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("68daf1e5-a756-47f6-9cb4-69eae8f79c8c"), "d30a7cc6-9db2-44f6-a330-9bfbf324779d", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("68daf1e5-a756-47f6-9cb4-69eae8f79c8c"), new Guid("d65c36fe-187b-4d17-aa33-41c9ea0dbcac") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d65c36fe-187b-4d17-aa33-41c9ea0dbcac"), 0, "bc781774-dd1b-4bde-a0fe-b2623c6d3ae2", new DateTime(1999, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhson3121999@gmail.com", true, "Thanh", "Son", false, null, "thanhson3121999@gmail.com", "admin", "AQAAAAEAACcQAAAAED7ZqkGBkrnl2Ikb9vFBj8EVORrFqxDKQZ8o/IPh8QxMZHYb2KBHjt9q2alUUEC5qA==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 23, 17, 13, 30, 620, DateTimeKind.Local).AddTicks(286));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("68daf1e5-a756-47f6-9cb4-69eae8f79c8c"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("68daf1e5-a756-47f6-9cb4-69eae8f79c8c"), new Guid("d65c36fe-187b-4d17-aa33-41c9ea0dbcac") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d65c36fe-187b-4d17-aa33-41c9ea0dbcac"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 23, 16, 52, 47, 263, DateTimeKind.Local).AddTicks(3402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 23, 17, 13, 30, 582, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 23, 16, 52, 47, 298, DateTimeKind.Local).AddTicks(7286));
        }
    }
}
