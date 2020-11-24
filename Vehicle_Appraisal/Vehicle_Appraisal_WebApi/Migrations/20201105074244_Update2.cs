using Microsoft.EntityFrameworkCore.Migrations;

namespace Vehicle_Appraisal_WebApi.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_AppUserRoles_AppUserRolesDTOId",
                table: "AppUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Conditions_Vehicles_VehicleDTOId",
                table: "Conditions");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleAppraisals_Vehicles_VehicleDTOId",
                table: "VehicleAppraisals");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Customers_CustomerDTOId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Makes_MakeDTOId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Models_ModelDTOId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_CustomerDTOId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_MakeDTOId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_ModelDTOId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_VehicleAppraisals_VehicleDTOId",
                table: "VehicleAppraisals");

            migrationBuilder.DropIndex(
                name: "IX_Conditions_VehicleDTOId",
                table: "Conditions");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_AppUserRolesDTOId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "CustomerDTOId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "MakeDTOId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ModelDTOId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "VehicleDTOId",
                table: "VehicleAppraisals");

            migrationBuilder.DropColumn(
                name: "VehicleDTOId",
                table: "Conditions");

            migrationBuilder.DropColumn(
                name: "AppUserRolesDTOId",
                table: "AppUsers");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserRolesId",
                table: "AppUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CustomerId",
                table: "Vehicles",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_MakeId",
                table: "Vehicles",
                column: "MakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ModelId",
                table: "Vehicles",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAppraisals_VehicleId",
                table: "VehicleAppraisals",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_VehicleId",
                table: "Conditions",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_AppUserRolesId",
                table: "AppUsers",
                column: "AppUserRolesId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_AppUserRoles_AppUserRolesId",
                table: "AppUsers",
                column: "AppUserRolesId",
                principalTable: "AppUserRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Conditions_Vehicles_VehicleId",
                table: "Conditions",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleAppraisals_Vehicles_VehicleId",
                table: "VehicleAppraisals",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Customers_CustomerId",
                table: "Vehicles",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Makes_MakeId",
                table: "Vehicles",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Models_ModelId",
                table: "Vehicles",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_AppUserRoles_AppUserRolesId",
                table: "AppUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Conditions_Vehicles_VehicleId",
                table: "Conditions");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleAppraisals_Vehicles_VehicleId",
                table: "VehicleAppraisals");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Customers_CustomerId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Makes_MakeId",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Models_ModelId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_CustomerId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_MakeId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_ModelId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_VehicleAppraisals_VehicleId",
                table: "VehicleAppraisals");

            migrationBuilder.DropIndex(
                name: "IX_Conditions_VehicleId",
                table: "Conditions");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_AppUserRolesId",
                table: "AppUsers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerDTOId",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MakeDTOId",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModelDTOId",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehicleDTOId",
                table: "VehicleAppraisals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehicleDTOId",
                table: "Conditions",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AppUserRolesId",
                table: "AppUsers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "AppUserRolesDTOId",
                table: "AppUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CustomerDTOId",
                table: "Vehicles",
                column: "CustomerDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_MakeDTOId",
                table: "Vehicles",
                column: "MakeDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ModelDTOId",
                table: "Vehicles",
                column: "ModelDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAppraisals_VehicleDTOId",
                table: "VehicleAppraisals",
                column: "VehicleDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_VehicleDTOId",
                table: "Conditions",
                column: "VehicleDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_AppUserRolesDTOId",
                table: "AppUsers",
                column: "AppUserRolesDTOId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_AppUserRoles_AppUserRolesDTOId",
                table: "AppUsers",
                column: "AppUserRolesDTOId",
                principalTable: "AppUserRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Conditions_Vehicles_VehicleDTOId",
                table: "Conditions",
                column: "VehicleDTOId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleAppraisals_Vehicles_VehicleDTOId",
                table: "VehicleAppraisals",
                column: "VehicleDTOId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Customers_CustomerDTOId",
                table: "Vehicles",
                column: "CustomerDTOId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Makes_MakeDTOId",
                table: "Vehicles",
                column: "MakeDTOId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Models_ModelDTOId",
                table: "Vehicles",
                column: "ModelDTOId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
