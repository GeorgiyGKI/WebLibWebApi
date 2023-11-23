using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLibWebApi.Migrations
{
    public partial class changedStatusConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "TransactionStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "In use");

            migrationBuilder.UpdateData(
                table: "TransactionStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Lost");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "TransactionStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Lost");

            migrationBuilder.UpdateData(
                table: "TransactionStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "In used");

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 16, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 11, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4352), new DateTime(2023, 10, 16, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 13, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 6, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 14, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4364), new DateTime(2023, 10, 20, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 9, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 12, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 7, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4371), new DateTime(2023, 10, 13, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 10, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 8, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 15, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CheckoutDate",
                value: new DateTime(2023, 10, 12, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 14, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4381), new DateTime(2023, 10, 18, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 10, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4384), new DateTime(2023, 10, 15, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 13, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4387), new DateTime(2023, 10, 20, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 8, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4390), new DateTime(2023, 10, 14, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 11, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4392), new DateTime(2023, 10, 17, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 9, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4395), new DateTime(2023, 10, 15, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 14, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4400), new DateTime(2023, 10, 19, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 10, 12, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4402), new DateTime(2023, 10, 18, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4403) });
        }
    }
}
