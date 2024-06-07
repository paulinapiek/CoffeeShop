using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoffeShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UsersDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", null, "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3987099b-3a5d-4cd0-904d-12a6d1f801bb", 0, "4882f25f-fb8d-47cf-a489-54def41c61e6", "testuser@gmail.com", false, true, null, "TESTUSER@GMAIL.COM", "TESTUSER@GMAIL.COM", "AQAAAAIAAYagAAAAEKF+gOXmZ8vIRbdG/MCOM0EH+cWvootd03tO51R4bqLajN6kWR+AX/szl7fc+hJnwA==", null, false, "FKVYI6UAIYDTXJV6OMMINLSSTNE6YCJK", false, "testuser@gmail.com" },
                    { "7c75c593-4454-4263-8959-9c419f94e7fc", 0, "433d2ef8-f135-481f-a694-4d1e1883499e", "testadmin@gmail.com", false, true, null, "TESTADMIN@GMAIL.COM", "TESTADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEBBICR9Vv3IsSs1SziaI9MY52RhRxhAqoCDhGKV/DZ35VrhiQfeyKuGmq+eY4U+z/g==", null, false, "V7LYP5BOZSODL7ZNRVQXQRV72NNG2BZ4", false, "testadmin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "7c75c593-4454-4263-8959-9c419f94e7fc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "7c75c593-4454-4263-8959-9c419f94e7fc" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3987099b-3a5d-4cd0-904d-12a6d1f801bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c75c593-4454-4263-8959-9c419f94e7fc");
        }
    }
}
