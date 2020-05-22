using Microsoft.EntityFrameworkCore.Migrations;

namespace Rocky.Migrations
{
    public partial class AddApplicationTypeToProduct_Rename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ApplicationType_ApplicationId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ApplicationId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationTypeId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ApplicationTypeId",
                table: "Product",
                column: "ApplicationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ApplicationType_ApplicationTypeId",
                table: "Product",
                column: "ApplicationTypeId",
                principalTable: "ApplicationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ApplicationType_ApplicationTypeId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ApplicationTypeId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ApplicationTypeId",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ApplicationId",
                table: "Product",
                column: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ApplicationType_ApplicationId",
                table: "Product",
                column: "ApplicationId",
                principalTable: "ApplicationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
