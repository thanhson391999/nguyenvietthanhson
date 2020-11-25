using Microsoft.EntityFrameworkCore.Migrations;

namespace Vehicle_Appraisal_WebApi.Migrations
{
    public partial class UpdateVehicleBought : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "vehicleId",
                table: "VehicleBoughts");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBoughts_vehicleAppraisalId",
                table: "VehicleBoughts",
                column: "vehicleAppraisalId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleBoughts_VehicleAppraisals_vehicleAppraisalId",
                table: "VehicleBoughts",
                column: "vehicleAppraisalId",
                principalTable: "VehicleAppraisals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleBoughts_VehicleAppraisals_vehicleAppraisalId",
                table: "VehicleBoughts");

            migrationBuilder.DropIndex(
                name: "IX_VehicleBoughts_vehicleAppraisalId",
                table: "VehicleBoughts");

            migrationBuilder.AddColumn<int>(
                name: "vehicleId",
                table: "VehicleBoughts",
                nullable: false,
                defaultValue: 0);
        }
    }
}
