using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb1.Migrations
{
    public partial class changedformatOnDateRemoved0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 1,
                column: "LoanDate",
                value: new DateTime(2022, 9, 22, 9, 49, 38, 857, DateTimeKind.Local).AddTicks(7892));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 1,
                column: "LoanDate",
                value: new DateTime(2022, 9, 22, 9, 48, 30, 710, DateTimeKind.Local).AddTicks(7308));
        }
    }
}
