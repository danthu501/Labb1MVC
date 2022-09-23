using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb1.Migrations
{
    public partial class AddedImagesToBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Books",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://bilder.akademibokhandeln.se/images_akb/9789174130348_383/stappens-krigare");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://bilder.akademibokhandeln.se/images_akb/9789186615499_383/azincourt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Books");
        }
    }
}
