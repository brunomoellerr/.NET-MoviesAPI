using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesAPI.Migrations
{
    public partial class relationmanagercinemas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Cinemas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_ManagerId",
                table: "Cinemas",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_Managers_ManagerId",
                table: "Cinemas",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_Managers_ManagerId",
                table: "Cinemas");

            migrationBuilder.DropIndex(
                name: "IX_Cinemas_ManagerId",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Cinemas");
        }
    }
}
