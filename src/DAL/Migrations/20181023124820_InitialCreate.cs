using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EngineType",
                columns: table => new
                {
                    EngineTypePK = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineType", x => x.EngineTypePK);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    ManufacturerPK = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ManufacturerName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.ManufacturerPK);
                });

            migrationBuilder.CreateTable(
                name: "TransmissionType",
                columns: table => new
                {
                    TransmissionTypePK = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransmissionType", x => x.TransmissionTypePK);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserPK = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Phone = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserPK);
                });

            migrationBuilder.CreateTable(
                name: "CarModel",
                columns: table => new
                {
                    ModelPK = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ModelName = table.Column<string>(maxLength: 50, nullable: true),
                    ManufacturerFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModel", x => x.ModelPK);
                    table.ForeignKey(
                        name: "FK_CarModel_Manufacturer_ManufacturerFK",
                        column: x => x.ManufacturerFK,
                        principalTable: "Manufacturer",
                        principalColumn: "ManufacturerPK",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Advertisement",
                columns: table => new
                {
                    AdvertisementPK = table.Column<Guid>(nullable: false),
                    UserFK = table.Column<Guid>(nullable: false),
                    ModelFK = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    ProductionYear = table.Column<DateTime>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    EngineTypeFK = table.Column<int>(nullable: false),
                    TransmissionTypeFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisement", x => x.AdvertisementPK);
                    table.ForeignKey(
                        name: "FK_Advertisement_EngineType_EngineTypeFK",
                        column: x => x.EngineTypeFK,
                        principalTable: "EngineType",
                        principalColumn: "EngineTypePK",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisement_CarModel_ModelFK",
                        column: x => x.ModelFK,
                        principalTable: "CarModel",
                        principalColumn: "ModelPK",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisement_TransmissionType_TransmissionTypeFK",
                        column: x => x.TransmissionTypeFK,
                        principalTable: "TransmissionType",
                        principalColumn: "TransmissionTypePK",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisement_User_UserFK",
                        column: x => x.UserFK,
                        principalTable: "User",
                        principalColumn: "UserPK",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    PhotoPK = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhotoURL = table.Column<string>(nullable: true),
                    AdvertisementPK = table.Column<Guid>(nullable: true),
                    AdvertisementFK = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.PhotoPK);
                    table.ForeignKey(
                        name: "FK_Photo_Advertisement_AdvertisementPK",
                        column: x => x.AdvertisementPK,
                        principalTable: "Advertisement",
                        principalColumn: "AdvertisementPK",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Advertisement_UserFK",
                table: "Advertisement",
                column: "UserFK");

            migrationBuilder.CreateIndex(
                name: "IX_CarModel_ManufacturerFK",
                table: "CarModel",
                column: "ManufacturerFK");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_AdvertisementPK",
                table: "Photo",
                column: "AdvertisementPK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Advertisement");

            migrationBuilder.DropTable(
                name: "EngineType");

            migrationBuilder.DropTable(
                name: "CarModel");

            migrationBuilder.DropTable(
                name: "TransmissionType");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Manufacturer");
        }
    }
}
