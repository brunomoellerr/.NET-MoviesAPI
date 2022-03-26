using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesAPI.Migrations
{
    public partial class addaddressforeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnderecoFK",
                table: "Cinemas");

            migrationBuilder.RenameColumn(
                name: "GerenteFK",
                table: "Cinemas",
                newName: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_AddressId",
                table: "Cinemas",
                column: "AddressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_Addresses_AddressId",
                table: "Cinemas",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_Addresses_AddressId",
                table: "Cinemas");

            migrationBuilder.DropIndex(
                name: "IX_Cinemas_AddressId",
                table: "Cinemas");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Cinemas",
                newName: "GerenteFK");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoFK",
                table: "Cinemas",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
