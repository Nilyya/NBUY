using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "750ebcc1-04a8-4405-b00a-9bd7d297528d", "0d56d210-3990-46aa-a367-33eb39dfe28f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2013f210-514c-490e-abc3-a6d4ae933ff6", "83c02b4f-513c-4c6d-ad96-b44c87c86035" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2013f210-514c-490e-abc3-a6d4ae933ff6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "750ebcc1-04a8-4405-b00a-9bd7d297528d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d56d210-3990-46aa-a367-33eb39dfe28f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83c02b4f-513c-4c6d-ad96-b44c87c86035");

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CardItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    CardId = table.Column<int>(type: "INTEGER", nullable: false),
                    CardItemsId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardItems_CardItems_CardItemsId",
                        column: x => x.CardItemsId,
                        principalTable: "CardItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CardItems_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6d712201-eaea-4cdc-b882-2148ee3a1433", null, "User rolü", "User", "USER" },
                    { "a9ca1ae2-f224-4bc3-bd33-cfa008851cfb", null, "Admin rolü", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "258bc7c5-2145-41c4-8f53-3a981039b72a", 0, "9955078c-4250-4f12-9338-ccf7854547a3", new DateTime(1985, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Kemal", "Erkek", "User", false, null, "USER@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEIjq1dIIpXiimK5JdMJTbDHbxgzIU8S6XLjvrg33BkmJUmiWPyViZn/BWcqzsbzDug==", null, false, "ac87f76c-e64e-4768-b24d-db7b0d95fb7e", false, "user" },
                    { "7b2a4373-4906-491c-b0d2-d5dadfaa571e", 0, "9058bfa9-e47b-42f9-b895-1758b429a8e7", new DateTime(1998, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Deniz", "Kadın", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEHUyzmGfD3LJ4M+QtpCz9FR5O3dvkEmZC7w5Pn64iGZROx2GrA5v7OniLcGfDBcKnQ==", null, false, "68b8d42c-05e9-48c7-9438-293970acb621", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6d712201-eaea-4cdc-b882-2148ee3a1433", "258bc7c5-2145-41c4-8f53-3a981039b72a" },
                    { "a9ca1ae2-f224-4bc3-bd33-cfa008851cfb", "7b2a4373-4906-491c-b0d2-d5dadfaa571e" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardItems_CardId",
                table: "CardItems",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_CardItems_CardItemsId",
                table: "CardItems",
                column: "CardItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_CardItems_ProductId",
                table: "CardItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_UserId",
                table: "Cards",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardItems");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6d712201-eaea-4cdc-b882-2148ee3a1433", "258bc7c5-2145-41c4-8f53-3a981039b72a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a9ca1ae2-f224-4bc3-bd33-cfa008851cfb", "7b2a4373-4906-491c-b0d2-d5dadfaa571e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d712201-eaea-4cdc-b882-2148ee3a1433");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9ca1ae2-f224-4bc3-bd33-cfa008851cfb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "258bc7c5-2145-41c4-8f53-3a981039b72a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b2a4373-4906-491c-b0d2-d5dadfaa571e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2013f210-514c-490e-abc3-a6d4ae933ff6", null, "Admin rolü", "Admin", "ADMIN" },
                    { "750ebcc1-04a8-4405-b00a-9bd7d297528d", null, "User rolü", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0d56d210-3990-46aa-a367-33eb39dfe28f", 0, "19627fd1-8f01-48e0-b1c6-6e0a415eca5a", new DateTime(1985, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Kemal", "Erkek", "User", false, null, "USER@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEKDnTtiBalWCnFyzqA+eAj/xapaEMsZL/RGrMwz8BzBdE1zYSjBwolCe42dyUJN3Yw==", null, false, "2dd1337b-44de-4344-989f-997049f5ea86", false, "user" },
                    { "83c02b4f-513c-4c6d-ad96-b44c87c86035", 0, "a7d8deea-e9af-41a6-b21c-040940733d7d", new DateTime(1998, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Deniz", "Kadın", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEFbU973o25acSqYQR15ftSNM4KHAf54mqle95LZow6WTBteI1PJgNSNalBQNO9Nn7w==", null, false, "8417645d-cac0-47e3-86a2-9d7a553bf875", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "750ebcc1-04a8-4405-b00a-9bd7d297528d", "0d56d210-3990-46aa-a367-33eb39dfe28f" },
                    { "2013f210-514c-490e-abc3-a6d4ae933ff6", "83c02b4f-513c-4c6d-ad96-b44c87c86035" }
                });
        }
    }
}
