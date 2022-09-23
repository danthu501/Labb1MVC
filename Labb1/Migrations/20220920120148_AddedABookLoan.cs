using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb1.Migrations
{
    public partial class AddedABookLoan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CustomerBooks",
                columns: new[] { "CustomerBookId", "BookId", "CustomerId", "LoanDate", "ReturnDate" },
                values: new object[] { 2, 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 2);
        }
    }
}
