using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLibWebApi.Migrations
{
    public partial class Identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 8, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 8, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 8, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 8, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 8, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 8, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 8, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 8, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 8, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 8, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 3, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 29, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7144), new DateTime(2023, 11, 3, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 31, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 24, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 1, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7151), new DateTime(2023, 11, 7, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 27, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 30, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 25, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7156), new DateTime(2023, 10, 31, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 28, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 26, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 2, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 30, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 1, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7164), new DateTime(2023, 11, 5, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 28, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7165), new DateTime(2023, 11, 2, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 31, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7167), new DateTime(2023, 11, 7, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 26, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7169), new DateTime(2023, 11, 1, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 29, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7171), new DateTime(2023, 11, 4, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 27, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7173), new DateTime(2023, 11, 2, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 1, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7174), new DateTime(2023, 11, 6, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7176), new DateTime(2023, 11, 5, 20, 42, 20, 992, DateTimeKind.Local).AddTicks(7177) });
        }
    }
}
