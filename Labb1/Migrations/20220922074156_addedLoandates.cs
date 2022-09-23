using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb1.Migrations
{
    public partial class addedLoandates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 1,
                columns: new[] { "LoanDate", "ReturnDate" },
                values: new object[] { new DateTime(2022, 9, 22, 9, 41, 56, 547, DateTimeKind.Local).AddTicks(7047), new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 1,
                columns: new[] { "LoanDate", "ReturnDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
