using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb1.Migrations
{
    public partial class AddedMoreBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Avalible", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 3, "Thomas Erikson", true, "https://s1.adlibris.com/images/43434791/omgiven-av-idioter-hur-man-forstar-dem-som-inte-gar-att-forsta.jpg", "Omgiven av idioter : hur man förstår dem som inte går att förstå" },
                    { 4, "David Sundin", true, "https://boktugg.imgix.net/9789179750961.jpg?w=400", "Boken som inte ville bli läst" }
                });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 1,
                columns: new[] { "LoanDate", "ReturnDate" },
                values: new object[] { new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 2,
                columns: new[] { "LoanDate", "ReturnDate" },
                values: new object[] { new DateTime(2022, 9, 22, 13, 39, 59, 704, DateTimeKind.Local).AddTicks(1837), new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 3,
                columns: new[] { "LoanDate", "ReturnDate" },
                values: new object[] { new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 1,
                columns: new[] { "LoanDate", "ReturnDate" },
                values: new object[] { new DateTime(2022, 9, 22, 9, 49, 38, 857, DateTimeKind.Local).AddTicks(7892), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 2,
                columns: new[] { "LoanDate", "ReturnDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 3,
                columns: new[] { "LoanDate", "ReturnDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
