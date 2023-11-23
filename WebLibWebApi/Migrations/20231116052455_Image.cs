using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLibWebApi.Migrations
{
    public partial class Image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DefaultQuantity",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Books",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 16, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 16, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 16, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 16, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 16, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 16, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 16, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 16, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 16, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 16, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 11, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 6, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7747), new DateTime(2023, 11, 11, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 8, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 1, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 9, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7754), new DateTime(2023, 11, 15, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 4, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 7, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 2, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7759), new DateTime(2023, 11, 8, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 5, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 3, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 10, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 7, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 9, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7765), new DateTime(2023, 11, 13, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 5, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7766), new DateTime(2023, 11, 10, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 8, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7768), new DateTime(2023, 11, 15, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 3, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7770), new DateTime(2023, 11, 9, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 6, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7772), new DateTime(2023, 11, 12, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 4, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7773), new DateTime(2023, 11, 10, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 9, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7775), new DateTime(2023, 11, 14, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 7, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7777), new DateTime(2023, 11, 13, 8, 24, 55, 61, DateTimeKind.Local).AddTicks(7777) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefaultQuantity",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 11, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 11, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 11, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 11, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 11, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 11, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 11, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 11, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 11, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 11, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 6, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1133), new DateTime(2023, 11, 6, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 3, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 27, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 4, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1142), new DateTime(2023, 11, 10, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 30, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 2, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 28, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1151), new DateTime(2023, 11, 3, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 31, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 29, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 5, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 2, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 4, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1161), new DateTime(2023, 11, 8, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 31, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1163), new DateTime(2023, 11, 5, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 3, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1166), new DateTime(2023, 11, 10, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 29, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1168), new DateTime(2023, 11, 4, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1170), new DateTime(2023, 11, 7, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 30, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1173), new DateTime(2023, 11, 5, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1174) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 4, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1176), new DateTime(2023, 11, 9, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 2, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1178), new DateTime(2023, 11, 8, 16, 17, 26, 524, DateTimeKind.Local).AddTicks(1179) });
        }
    }
}
