using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class migbirlestirme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "socialIcon",
                table: "EkipTanitims",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "socialName",
                table: "EkipTanitims",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "socialStatus",
                table: "EkipTanitims",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "socialUrl",
                table: "EkipTanitims",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "socialIcon",
                table: "EkipTanitims");

            migrationBuilder.DropColumn(
                name: "socialName",
                table: "EkipTanitims");

            migrationBuilder.DropColumn(
                name: "socialStatus",
                table: "EkipTanitims");

            migrationBuilder.DropColumn(
                name: "socialUrl",
                table: "EkipTanitims");
        }
    }
}
