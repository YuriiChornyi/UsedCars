using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class changerelationbetweenCarandAdvertisement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisement_Car_CarId",
                table: "Advertisement");

            migrationBuilder.DropIndex(
                name: "IX_Advertisement_CarId",
                table: "Advertisement");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Advertisement");

            migrationBuilder.AddColumn<Guid>(
                name: "AdvertisementId",
                table: "Car",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Car_AdvertisementId",
                table: "Car",
                column: "AdvertisementId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Advertisement_AdvertisementId",
                table: "Car",
                column: "AdvertisementId",
                principalTable: "Advertisement",
                principalColumn: "AdvertisementId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Advertisement_AdvertisementId",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_AdvertisementId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "AdvertisementId",
                table: "Car");

            migrationBuilder.AddColumn<Guid>(
                name: "CarId",
                table: "Advertisement",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Advertisement_CarId",
                table: "Advertisement",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisement_Car_CarId",
                table: "Advertisement",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
