using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb1.Migrations
{
    public partial class AddedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Avalible", "Title" },
                values: new object[] { 1, "Conn Iggulden", true, "Stäppens krigare" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName" },
                values: new object[] { 1, "Anas@qlok.se", "Anas", "Qlok" });

            migrationBuilder.InsertData(
                table: "CustomerBooks",
                columns: new[] { "CustomerBookId", "BookId", "CustomerId" },
                values: new object[] { 1, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);
        }
    }
}
