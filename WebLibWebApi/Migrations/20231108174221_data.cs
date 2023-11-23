using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLibWebApi.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TransactionStatuses",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TransactionStatuses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 30, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 30, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 30, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 30, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 30, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 30, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 30, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 30, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 30, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 30, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 25, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 20, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 10, 25, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 22, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 15, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 23, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8978), new DateTime(2023, 10, 29, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 18, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 21, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 16, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8982), new DateTime(2023, 10, 22, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 19, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 17, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 24, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 21, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 23, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8989), new DateTime(2023, 10, 27, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 19, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8991), new DateTime(2023, 10, 24, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 22, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8993), new DateTime(2023, 10, 29, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 17, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8995), new DateTime(2023, 10, 23, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 20, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8997), new DateTime(2023, 10, 26, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 18, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(9000), new DateTime(2023, 10, 24, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 23, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(9002), new DateTime(2023, 10, 28, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 21, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(9004), new DateTime(2023, 10, 27, 9, 18, 9, 771, DateTimeKind.Local).AddTicks(9005) });
        }
    }
}
