using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb1.Migrations
{
    public partial class changedformatOnDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 1,
                column: "LoanDate",
                value: new DateTime(2022, 9, 22, 9, 48, 30, 710, DateTimeKind.Local).AddTicks(7308));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 1,
                column: "LoanDate",
                value: new DateTime(2022, 9, 22, 9, 41, 56, 547, DateTimeKind.Local).AddTicks(7047));
        }
    }
}
