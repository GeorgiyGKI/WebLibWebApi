using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLibWebApi.Migrations
{
    public partial class newPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b0071dc-73bd-42aa-aef0-f1edd51aa49e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8c67ead-9505-4806-a937-e04a46caef78");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6f3fa859-baeb-402b-8006-7c4e2f047f1b", "a8dfc2ca-c3e2-48de-938e-605b00200f6d", "Moderator", "MODERATOR" },
                    { "e089cb67-1dd1-4c12-bf00-08af4a4b12e2", "df9f28f8-e449-4522-970e-21d1f425ed82", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2023, 12, 31, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2023, 12, 31, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2023, 12, 31, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2023, 12, 31, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2023, 12, 31, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2023, 12, 31, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2023, 12, 31, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2023, 12, 31, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2023, 12, 31, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2023, 12, 31, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CheckoutDate",
                value: new DateTime(2023, 12, 26, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 12, 21, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2859), new DateTime(2023, 12, 26, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CheckoutDate",
                value: new DateTime(2023, 12, 23, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CheckoutDate",
                value: new DateTime(2023, 12, 16, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 12, 24, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2866), new DateTime(2023, 12, 30, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CheckoutDate",
                value: new DateTime(2023, 12, 19, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CheckoutDate",
                value: new DateTime(2023, 12, 22, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 12, 17, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2871), new DateTime(2023, 12, 23, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CheckoutDate",
                value: new DateTime(2023, 12, 20, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CheckoutDate",
                value: new DateTime(2023, 12, 18, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CheckoutDate",
                value: new DateTime(2023, 12, 25, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CheckoutDate",
                value: new DateTime(2023, 12, 22, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 12, 24, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2877), new DateTime(2023, 12, 28, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2878), new DateTime(2023, 12, 25, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2882), new DateTime(2023, 12, 30, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 12, 18, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2884), new DateTime(2023, 12, 24, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 12, 21, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2885), new DateTime(2023, 12, 27, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 12, 19, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2887), new DateTime(2023, 12, 25, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 12, 24, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2889), new DateTime(2023, 12, 29, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 12, 22, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2891), new DateTime(2023, 12, 28, 11, 11, 6, 474, DateTimeKind.Local).AddTicks(2891) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f3fa859-baeb-402b-8006-7c4e2f047f1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e089cb67-1dd1-4c12-bf00-08af4a4b12e2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7b0071dc-73bd-42aa-aef0-f1edd51aa49e", "71a531ff-880b-418f-89ca-c1ffb4306c04", "Administrator", "ADMINISTRATOR" },
                    { "d8c67ead-9505-4806-a937-e04a46caef78", "3be17055-e607-4290-896d-43c6facd959f", "Moderator", "MODERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 18, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 18, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 18, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 4,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 18, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 5,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 18, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 6,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 18, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 7,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 18, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 8,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 18, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 9,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 18, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: 10,
                column: "RegistrationDate",
                value: new DateTime(2023, 11, 18, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 13, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 8, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8252), new DateTime(2023, 11, 13, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 10, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 3, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 11, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8260), new DateTime(2023, 11, 17, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 6, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 9, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 4, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8265), new DateTime(2023, 11, 10, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 7, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 5, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 12, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CheckoutDate",
                value: new DateTime(2023, 11, 9, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 11, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8273), new DateTime(2023, 11, 15, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 7, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8275), new DateTime(2023, 11, 12, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 10, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8277), new DateTime(2023, 11, 17, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 5, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8280), new DateTime(2023, 11, 11, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 8, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8282), new DateTime(2023, 11, 14, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 6, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8284), new DateTime(2023, 11, 12, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 11, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8286), new DateTime(2023, 11, 16, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckoutDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 11, 9, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8289), new DateTime(2023, 11, 15, 11, 36, 42, 714, DateTimeKind.Local).AddTicks(8290) });
        }
    }
}
