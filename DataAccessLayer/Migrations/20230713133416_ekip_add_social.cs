using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class ekip_add_social : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FaceIcon",
                table: "EkipTanitims",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FaceName",
                table: "EkipTanitims",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FaceUrl",
                table: "EkipTanitims",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsIcon",
                table: "EkipTanitims",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsName",
                table: "EkipTanitims",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsUrl",
                table: "EkipTanitims",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinIcon",
                table: "EkipTanitims",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinName",
                table: "EkipTanitims",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinUrl",
                table: "EkipTanitims",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FaceIcon",
                table: "EkipTanitims");

            migrationBuilder.DropColumn(
                name: "FaceName",
                table: "EkipTanitims");

            migrationBuilder.DropColumn(
                name: "FaceUrl",
                table: "EkipTanitims");

            migrationBuilder.DropColumn(
                name: "InsIcon",
                table: "EkipTanitims");

            migrationBuilder.DropColumn(
                name: "InsName",
                table: "EkipTanitims");

            migrationBuilder.DropColumn(
                name: "InsUrl",
                table: "EkipTanitims");

            migrationBuilder.DropColumn(
                name: "LinIcon",
                table: "EkipTanitims");

            migrationBuilder.DropColumn(
                name: "LinName",
                table: "EkipTanitims");

            migrationBuilder.DropColumn(
                name: "LinUrl",
                table: "EkipTanitims");
        }
    }
}
