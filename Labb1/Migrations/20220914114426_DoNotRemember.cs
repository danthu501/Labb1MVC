using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb1.Migrations
{
    public partial class DoNotRemember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName" },
                values: new object[] { 1, "Anas@qlok.se", "Anas", "Qlok" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName" },
                values: new object[] { 2, "danne@gmail.se", "Daniel", "Thulin" });

            migrationBuilder.InsertData(
                table: "CustomerBooks",
                columns: new[] { "CustomerBookId", "BookId", "CustomerId", "LoanDate", "ReturnDate" },
                values: new object[] { 1, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "CustomerBooks",
                columns: new[] { "CustomerBookId", "BookId", "CustomerId", "LoanDate", "ReturnDate" },
                values: new object[] { 3, 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName" },
                values: new object[] { 1, "Anas@qlok.se", "Anas", "Qlok" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName" },
                values: new object[] { 2, "danne@gmail.se", "Daniel", "Thulin" });

            migrationBuilder.InsertData(
                table: "CustomerBooks",
                columns: new[] { "CustomerBookId", "BookId", "CustomerId", "LoanDate", "ReturnDate" },
                values: new object[] { 1, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "CustomerBooks",
                columns: new[] { "CustomerBookId", "BookId", "CustomerId", "LoanDate", "ReturnDate" },
                values: new object[] { 3, 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
