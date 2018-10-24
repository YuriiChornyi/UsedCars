using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ChangePKtoidandtablesimprovement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisement_EngineType_EngineTypeFK",
                table: "Advertisement");

            migrationBuilder.DropForeignKey(
                name: "FK_Advertisement_CarModel_ModelFK",
                table: "Advertisement");

            migrationBuilder.DropForeignKey(
                name: "FK_Advertisement_TransmissionType_TransmissionTypeFK",
                table: "Advertisement");

            migrationBuilder.DropForeignKey(
                name: "FK_Advertisement_User_UserFK",
                table: "Advertisement");

            migrationBuilder.DropForeignKey(
                name: "FK_CarModel_Manufacturer_ManufacturerFK",
                table: "CarModel");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Advertisement_AdvertisementPK",
                table: "Photo");

            migrationBuilder.DropIndex(
                name: "IX_Photo_AdvertisementPK",
                table: "Photo");

            migrationBuilder.DropIndex(
                name: "IX_Advertisement_EngineTypeFK",
                table: "Advertisement");

            migrationBuilder.DropIndex(
                name: "IX_Advertisement_ModelFK",
                table: "Advertisement");

            migrationBuilder.DropIndex(
                name: "IX_Advertisement_TransmissionTypeFK",
                table: "Advertisement");

            migrationBuilder.DropColumn(
                name: "AdvertisementPK",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "EngineTypeFK",
                table: "Advertisement");

            migrationBuilder.DropColumn(
                name: "ModelFK",
                table: "Advertisement");

            migrationBuilder.DropColumn(
                name: "ProductionYear",
                table: "Advertisement");

            migrationBuilder.DropColumn(
                name: "TransmissionTypeFK",
                table: "Advertisement");

            migrationBuilder.RenameColumn(
                name: "UserPK",
                table: "User",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "TransmissionTypePK",
                table: "TransmissionType",
                newName: "TransmissionTypeId");

            migrationBuilder.RenameColumn(
                name: "AdvertisementFK",
                table: "Photo",
                newName: "AdvertisementId");

            migrationBuilder.RenameColumn(
                name: "PhotoPK",
                table: "Photo",
                newName: "PhotoId");

            migrationBuilder.RenameColumn(
                name: "ManufacturerPK",
                table: "Manufacturer",
                newName: "ManufacturerId");

            migrationBuilder.RenameColumn(
                name: "EngineTypePK",
                table: "EngineType",
                newName: "EngineTypeId");

            migrationBuilder.RenameColumn(
                name: "ModelName",
                table: "CarModel",
                newName: "CarModelName");

            migrationBuilder.RenameColumn(
                name: "ManufacturerFK",
                table: "CarModel",
                newName: "ManufacturerId");

            migrationBuilder.RenameColumn(
                name: "ModelPK",
                table: "CarModel",
                newName: "CarModelId");

            migrationBuilder.RenameIndex(
                name: "IX_CarModel_ManufacturerFK",
                table: "CarModel",
                newName: "IX_CarModel_ManufacturerId");

            migrationBuilder.RenameColumn(
                name: "UserFK",
                table: "Advertisement",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "AdvertisementPK",
                table: "Advertisement",
                newName: "AdvertisementId");

            migrationBuilder.RenameIndex(
                name: "IX_Advertisement_UserFK",
                table: "Advertisement",
                newName: "IX_Advertisement_UserId");

            migrationBuilder.AddColumn<Guid>(
                name: "CarId",
                table: "Advertisement",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Engine",
                columns: table => new
                {
                    EngineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EngineTypeId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    HP = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engine", x => x.EngineId);
                    table.ForeignKey(
                        name: "FK_Engine_EngineType_EngineTypeId",
                        column: x => x.EngineTypeId,
                        principalTable: "EngineType",
                        principalColumn: "EngineTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GearBoxType",
                columns: table => new
                {
                    GearBoxTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearBoxType", x => x.GearBoxTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Transmission",
                columns: table => new
                {
                    TransmissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GearBoxTypeId = table.Column<int>(nullable: false),
                    TransmissionTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmission", x => x.TransmissionId);
                    table.ForeignKey(
                        name: "FK_Transmission_GearBoxType_GearBoxTypeId",
                        column: x => x.GearBoxTypeId,
                        principalTable: "GearBoxType",
                        principalColumn: "GearBoxTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transmission_TransmissionType_TransmissionTypeId",
                        column: x => x.TransmissionTypeId,
                        principalTable: "TransmissionType",
                        principalColumn: "TransmissionTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarId = table.Column<Guid>(nullable: false),
                    EngineId = table.Column<int>(nullable: false),
                    TransmissionId = table.Column<int>(nullable: false),
                    CarModelId = table.Column<int>(nullable: false),
                    ProductionYear = table.Column<DateTime>(nullable: true),
                    VinCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Car_CarModel_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModel",
                        principalColumn: "CarModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Car_Engine_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engine",
                        principalColumn: "EngineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Car_Transmission_TransmissionId",
                        column: x => x.TransmissionId,
                        principalTable: "Transmission",
                        principalColumn: "TransmissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photo_AdvertisementId",
                table: "Photo",
                column: "AdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisement_CarId",
                table: "Advertisement",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_CarModelId",
                table: "Car",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_EngineId",
                table: "Car",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_TransmissionId",
                table: "Car",
                column: "TransmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Engine_EngineTypeId",
                table: "Engine",
                column: "EngineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Transmission_GearBoxTypeId",
                table: "Transmission",
                column: "GearBoxTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Transmission_TransmissionTypeId",
                table: "Transmission",
                column: "TransmissionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisement_Car_CarId",
                table: "Advertisement",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisement_User_UserId",
                table: "Advertisement",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarModel_Manufacturer_ManufacturerId",
                table: "CarModel",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "ManufacturerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Advertisement_AdvertisementId",
                table: "Photo",
                column: "AdvertisementId",
                principalTable: "Advertisement",
                principalColumn: "AdvertisementId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisement_Car_CarId",
                table: "Advertisement");

            migrationBuilder.DropForeignKey(
                name: "FK_Advertisement_User_UserId",
                table: "Advertisement");

            migrationBuilder.DropForeignKey(
                name: "FK_CarModel_Manufacturer_ManufacturerId",
                table: "CarModel");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Advertisement_AdvertisementId",
                table: "Photo");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Engine");

            migrationBuilder.DropTable(
                name: "Transmission");

            migrationBuilder.DropTable(
                name: "GearBoxType");

            migrationBuilder.DropIndex(
                name: "IX_Photo_AdvertisementId",
                table: "Photo");

            migrationBuilder.DropIndex(
                name: "IX_Advertisement_CarId",
                table: "Advertisement");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Advertisement");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "User",
                newName: "UserPK");

            migrationBuilder.RenameColumn(
                name: "TransmissionTypeId",
                table: "TransmissionType",
                newName: "TransmissionTypePK");

            migrationBuilder.RenameColumn(
                name: "AdvertisementId",
                table: "Photo",
                newName: "AdvertisementFK");

            migrationBuilder.RenameColumn(
                name: "PhotoId",
                table: "Photo",
                newName: "PhotoPK");

            migrationBuilder.RenameColumn(
                name: "ManufacturerId",
                table: "Manufacturer",
                newName: "ManufacturerPK");

            migrationBuilder.RenameColumn(
                name: "EngineTypeId",
                table: "EngineType",
                newName: "EngineTypePK");

            migrationBuilder.RenameColumn(
                name: "ManufacturerId",
                table: "CarModel",
                newName: "ManufacturerFK");

            migrationBuilder.RenameColumn(
                name: "CarModelName",
                table: "CarModel",
                newName: "ModelName");

            migrationBuilder.RenameColumn(
                name: "CarModelId",
                table: "CarModel",
                newName: "ModelPK");

            migrationBuilder.RenameIndex(
                name: "IX_CarModel_ManufacturerId",
                table: "CarModel",
                newName: "IX_CarModel_ManufacturerFK");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Advertisement",
                newName: "UserFK");

            migrationBuilder.RenameColumn(
                name: "AdvertisementId",
                table: "Advertisement",
                newName: "AdvertisementPK");

            migrationBuilder.RenameIndex(
                name: "IX_Advertisement_UserId",
                table: "Advertisement",
                newName: "IX_Advertisement_UserFK");

            migrationBuilder.AddColumn<Guid>(
                name: "AdvertisementPK",
                table: "Photo",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EngineTypeFK",
                table: "Advertisement",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModelFK",
                table: "Advertisement",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProductionYear",
                table: "Advertisement",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TransmissionTypeFK",
                table: "Advertisement",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Photo_AdvertisementPK",
                table: "Photo",
                column: "AdvertisementPK");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisement_EngineTypeFK",
                table: "Advertisement",
                column: "EngineTypeFK");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisement_ModelFK",
                table: "Advertisement",
                column: "ModelFK");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisement_TransmissionTypeFK",
                table: "Advertisement",
                column: "TransmissionTypeFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisement_EngineType_EngineTypeFK",
                table: "Advertisement",
                column: "EngineTypeFK",
                principalTable: "EngineType",
                principalColumn: "EngineTypePK",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisement_CarModel_ModelFK",
                table: "Advertisement",
                column: "ModelFK",
                principalTable: "CarModel",
                principalColumn: "ModelPK",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisement_TransmissionType_TransmissionTypeFK",
                table: "Advertisement",
                column: "TransmissionTypeFK",
                principalTable: "TransmissionType",
                principalColumn: "TransmissionTypePK",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisement_User_UserFK",
                table: "Advertisement",
                column: "UserFK",
                principalTable: "User",
                principalColumn: "UserPK",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarModel_Manufacturer_ManufacturerFK",
                table: "CarModel",
                column: "ManufacturerFK",
                principalTable: "Manufacturer",
                principalColumn: "ManufacturerPK",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Advertisement_AdvertisementPK",
                table: "Photo",
                column: "AdvertisementPK",
                principalTable: "Advertisement",
                principalColumn: "AdvertisementPK",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
