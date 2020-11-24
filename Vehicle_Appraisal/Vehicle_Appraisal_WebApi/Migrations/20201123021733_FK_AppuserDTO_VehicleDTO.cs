using Microsoft.EntityFrameworkCore.Migrations;

namespace Vehicle_Appraisal_WebApi.Migrations
{
    public partial class FK_AppuserDTO_VehicleDTO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_AppUserId",
                table: "Vehicles",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_AppUsers_AppUserId",
                table: "Vehicles",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_AppUsers_AppUserId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_AppUserId",
                table: "Vehicles");
        }
    }
}
