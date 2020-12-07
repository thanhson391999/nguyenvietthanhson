using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Vehicle_Appraisal_WebApi.Migrations
{
    public partial class updateVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleBoughts");

            migrationBuilder.RenameColumn(
                name: "isDelete",
                table: "Vehicles",
                newName: "isBought");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isBought",
                table: "Vehicles",
                newName: "isDelete");

            migrationBuilder.CreateTable(
                name: "VehicleBoughts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: false),
                    vehicleAppraisalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleBoughts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleBoughts_VehicleAppraisals_vehicleAppraisalId",
                        column: x => x.vehicleAppraisalId,
                        principalTable: "VehicleAppraisals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleBoughts_vehicleAppraisalId",
                table: "VehicleBoughts",
                column: "vehicleAppraisalId");
        }
    }
}
