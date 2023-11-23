using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLibWebApi.Migrations
{
    public partial class initialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Readers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Readers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReaderId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CheckoutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TransactionStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Readers_ReaderId",
                        column: x => x.ReaderId,
                        principalTable: "Readers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_TransactionStatuses_TransactionStatusId",
                        column: x => x.TransactionStatusId,
                        principalTable: "TransactionStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "Country", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "John", "Doe" },
                    { 2, new DateTime(1975, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "UK", "Jane", "Smith" },
                    { 3, new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canada", "David", "Johnson" },
                    { 4, new DateTime(1988, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Australia", "Emma", "Brown" },
                    { 5, new DateTime(1972, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Germany", "Michael", "Davis" },
                    { 6, new DateTime(1985, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "France", "Sophia", "Miller" },
                    { 7, new DateTime(1990, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japan", "Daniel", "Wilson" },
                    { 8, new DateTime(1978, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brazil", "Olivia", "Moore" },
                    { 9, new DateTime(1983, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "South Africa", "Ethan", "Lee" },
                    { 10, new DateTime(1970, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Russia", "Ava", "Anderson" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mystery" },
                    { 2, "Science Fiction" },
                    { 3, "Romance" },
                    { 4, "Thriller" },
                    { 5, "Fantasy" },
                    { 6, "Historical Fiction" },
                    { 7, "Biography" },
                    { 8, "Adventure" },
                    { 9, "Horror" },
                    { 10, "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "PhoneNumber", "RegistrationDate" },
                values: new object[,]
                {
                    { 1, "123 Main St", "John", "Doe", "555-1234", new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3626) },
                    { 2, "456 Oak St", "Jane", "Smith", "555-5678", new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3643) },
                    { 3, "789 Pine St", "Robert", "Johnson", "555-9101", new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3645) },
                    { 4, "101 Elm St", "Emily", "Williams", "555-1212", new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3646) },
                    { 5, "202 Birch St", "Michael", "Brown", "555-1414", new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3648) },
                    { 6, "303 Maple St", "Olivia", "Jones", "555-1616", new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3649) },
                    { 7, "404 Cedar St", "William", "Davis", "555-1818", new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3903) },
                    { 8, "505 Redwood St", "Sophia", "Miller", "555-2020", new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3914) },
                    { 9, "606 Pine St", "James", "Wilson", "555-2222", new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3916) },
                    { 10, "707 Oak St", "Emma", "Moore", "555-2424", new DateTime(2023, 10, 21, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(3918) }
                });

            migrationBuilder.InsertData(
                table: "TransactionStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Lost" },
                    { 2, "Returned" },
                    { 3, "In used" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "GenreId", "Quantity", "Title", "Year" },
                values: new object[,]
                {
                    { 1, 1, 1, 10, "The Da Vinci Code", 2003 },
                    { 2, 2, 2, 8, "Dune", 1965 },
                    { 3, 3, 3, 15, "Pride and Prejudice", 1813 },
                    { 4, 4, 4, 12, "The Girl with the Dragon Tattoo", 2005 },
                    { 5, 5, 5, 20, "Harry Potter and the Sorcerer's Stone", 1997 },
                    { 6, 6, 6, 18, "The Great Gatsby", 1925 },
                    { 7, 7, 7, 9, "Steve Jobs", 2011 },
                    { 8, 8, 8, 14, "The Hobbit", 1937 },
                    { 9, 9, 9, 11, "It", 1986 },
                    { 10, 10, 10, 16, "Romeo and Juliet", 1597 },
                    { 11, 2, 1, 7, "The Hound of the Baskervilles", 1902 },
                    { 12, 2, 2, 10, "Neuromancer", 1984 },
                    { 13, 5, 3, 13, "Sense and Sensibility", 1811 },
                    { 14, 5, 2, 15, "The Girl Who Played with Fire", 2006 },
                    { 15, 5, 2, 18, "Harry Potter and the Chamber of Secrets", 1998 },
                    { 16, 6, 6, 21, "To Kill a Mockingbird", 1960 },
                    { 17, 7, 7, 8, "Einstein: His Life and Universe", 2007 },
                    { 18, 8, 7, 12, "The Lord of the Rings", 1954 },
                    { 19, 3, 9, 14, "The Shining", 1977 },
                    { 20, 10, 10, 17, "Macbeth", 1606 }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "BookId", "CheckoutDate", "ReaderId", "ReturnDate", "TransactionStatusId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 16, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4344), 1, null, 1 },
                    { 2, 3, new DateTime(2023, 10, 11, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4352), 2, new DateTime(2023, 10, 16, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4354), 2 },
                    { 3, 2, new DateTime(2023, 10, 13, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4361), 3, null, 1 },
                    { 4, 5, new DateTime(2023, 10, 6, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4362), 4, null, 3 },
                    { 5, 4, new DateTime(2023, 10, 14, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4364), 5, new DateTime(2023, 10, 20, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4365), 2 },
                    { 6, 6, new DateTime(2023, 10, 9, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4367), 6, null, 1 },
                    { 7, 8, new DateTime(2023, 10, 12, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4369), 7, null, 3 },
                    { 8, 7, new DateTime(2023, 10, 7, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4371), 8, new DateTime(2023, 10, 13, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4372), 2 },
                    { 9, 10, new DateTime(2023, 10, 10, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4374), 9, null, 1 },
                    { 10, 9, new DateTime(2023, 10, 8, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4376), 10, null, 3 },
                    { 11, 7, new DateTime(2023, 10, 15, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4377), 1, null, 1 },
                    { 12, 9, new DateTime(2023, 10, 12, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4379), 2, null, 3 },
                    { 13, 8, new DateTime(2023, 10, 14, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4381), 3, new DateTime(2023, 10, 18, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4381), 2 },
                    { 14, 10, new DateTime(2023, 10, 10, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4384), 4, new DateTime(2023, 10, 15, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4385), 2 },
                    { 15, 6, new DateTime(2023, 10, 13, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4387), 5, new DateTime(2023, 10, 20, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4388), 2 },
                    { 16, 4, new DateTime(2023, 10, 8, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4390), 6, new DateTime(2023, 10, 14, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4391), 2 },
                    { 17, 5, new DateTime(2023, 10, 11, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4392), 7, new DateTime(2023, 10, 17, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4394), 3 },
                    { 18, 3, new DateTime(2023, 10, 9, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4395), 8, new DateTime(2023, 10, 15, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4397), 2 },
                    { 19, 2, new DateTime(2023, 10, 14, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4400), 9, new DateTime(2023, 10, 19, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4401), 2 },
                    { 20, 1, new DateTime(2023, 10, 12, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4402), 10, new DateTime(2023, 10, 18, 12, 29, 16, 318, DateTimeKind.Local).AddTicks(4403), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_BookId",
                table: "Transactions",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ReaderId",
                table: "Transactions",
                column: "ReaderId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TransactionStatusId",
                table: "Transactions",
                column: "TransactionStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Readers");

            migrationBuilder.DropTable(
                name: "TransactionStatuses");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
