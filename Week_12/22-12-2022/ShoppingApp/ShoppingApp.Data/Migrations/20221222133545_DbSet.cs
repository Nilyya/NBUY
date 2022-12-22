using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class DbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4bed9736-3248-4385-851d-06f37d2a7d15", "5f70edbc-b1c9-49e6-9a9b-5e4cc8792bea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8be23eb5-fbdc-476e-97fc-6f32236111e2", "a8e739ed-9351-4569-87bf-a8a82998374c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4bed9736-3248-4385-851d-06f37d2a7d15");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8be23eb5-fbdc-476e-97fc-6f32236111e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f70edbc-b1c9-49e6-9a9b-5e4cc8792bea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8e739ed-9351-4569-87bf-a8a82998374c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "72037034-a730-4041-9a8e-1797197ea068", null, "User rolü", "User", "USER" },
                    { "d7ed7e37-68d3-459d-9d0f-d4552bc94377", null, "Admin rolü", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "19f1657a-50eb-47e8-8def-bc010d4777ef", 0, "Çek Cd. Senet Sk. Fatura Ap", "İstanbul", "3d1d6bbd-8c0d-4215-adc3-e70e56d1f69e", new DateTime(1998, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Deniz", "Kadın", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEPNbLD++6fQX1N+/qDSnLarkWHUoyzkpbzS90BAYRFB4+JT+EySHAyng1d8/IUQ3BA==", "5555555555", false, "4e354992-3a63-4fc5-a415-373aea75e9ce", false, "admin" },
                    { "e08dbec2-c782-4496-ad64-f2a4f02b94ab", 0, "Akasya Cd. Orkide Sk. Gül Ap", "İzmir", "ff7083e8-b959-4c06-b51c-f3673785eb03", new DateTime(1985, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Kemal", "Erkek", "User", false, null, "USER@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEDLDpkadd2YtrKaTUJo5yJ77c0lOYMRZTvSTmQys58CVxk9WcVVWb/5L7GFyGSLemg==", "4444444444", false, "52669b7b-4259-4f1c-a257-c5c095fb45cb", false, "user" }
                });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "19f1657a-50eb-47e8-8def-bc010d4777ef");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "e08dbec2-c782-4496-ad64-f2a4f02b94ab");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d7ed7e37-68d3-459d-9d0f-d4552bc94377", "19f1657a-50eb-47e8-8def-bc010d4777ef" },
                    { "72037034-a730-4041-9a8e-1797197ea068", "e08dbec2-c782-4496-ad64-f2a4f02b94ab" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d7ed7e37-68d3-459d-9d0f-d4552bc94377", "19f1657a-50eb-47e8-8def-bc010d4777ef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72037034-a730-4041-9a8e-1797197ea068", "e08dbec2-c782-4496-ad64-f2a4f02b94ab" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72037034-a730-4041-9a8e-1797197ea068");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7ed7e37-68d3-459d-9d0f-d4552bc94377");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19f1657a-50eb-47e8-8def-bc010d4777ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e08dbec2-c782-4496-ad64-f2a4f02b94ab");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4bed9736-3248-4385-851d-06f37d2a7d15", null, "Admin rolü", "Admin", "ADMIN" },
                    { "8be23eb5-fbdc-476e-97fc-6f32236111e2", null, "User rolü", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5f70edbc-b1c9-49e6-9a9b-5e4cc8792bea", 0, "Çek Cd. Senet Sk. Fatura Ap", "İstanbul", "e1696766-93d3-410f-a468-7c704d4a85da", new DateTime(1998, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Deniz", "Kadın", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEHQibp3XKdDlTlzv2bY5oku+nSilvMUg3GxRaXmDWQfoXPZHeAK8vKEwEN6V+JBVRg==", "5555555555", false, "d8bfff8d-a501-4468-8b20-2a34f76a2471", false, "admin" },
                    { "a8e739ed-9351-4569-87bf-a8a82998374c", 0, "Akasya Cd. Orkide Sk. Gül Ap", "İzmir", "226a55e2-bbd8-4e06-8cc8-5c8a4b3b8be6", new DateTime(1985, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Kemal", "Erkek", "User", false, null, "USER@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEPElWjZBBV4nJZhew7IHsDfzl2JphWu48Hzj1mkiGR24zmwSBGURZ8ZzIMflul5dBA==", "4444444444", false, "cdb0ce92-abee-46a7-8e2a-d58fed6af626", false, "user" }
                });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "5f70edbc-b1c9-49e6-9a9b-5e4cc8792bea");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "a8e739ed-9351-4569-87bf-a8a82998374c");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4bed9736-3248-4385-851d-06f37d2a7d15", "5f70edbc-b1c9-49e6-9a9b-5e4cc8792bea" },
                    { "8be23eb5-fbdc-476e-97fc-6f32236111e2", "a8e739ed-9351-4569-87bf-a8a82998374c" }
                });
        }
    }
}
