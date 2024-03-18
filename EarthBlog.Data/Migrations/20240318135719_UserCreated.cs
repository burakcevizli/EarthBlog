using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EarthBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a7ad864e-2ed0-4617-951f-04f72b409d9a"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("eaf49916-65e7-416c-8287-d147937c832f"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedTime", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("48407d35-45cb-4e4c-8cda-d7244a486390"), new Guid("fd18e57b-2b39-4768-a1f3-2300c7c2069a"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ac justo eget leo fringilla suscipit. Nullam vitae sapien vel ligula ultrices fermentum. Phasellus sollicitudin, nisi a fermentum convallis, eros dui varius ex, sed hendrerit ligula nisi eget magna. Integer posuere nibh at sem faucibus, in accumsan quam efficitur. Vivamus nec mi nec dolor fermentum aliquam. Duis ullamcorper feugiat magna, a suscipit metus mattis nec. Quisque sed velit quis nisi convallis feugiat nec eu lacus. Proin id ipsum sit amet magna consequat aliquet. Ut viverra magna in erat laoreet, ac lacinia ipsum luctus. Nam sodales convallis aliquam. Morbi in libero urna. Fusce sed est a nulla tincidunt tempus non eu odio. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer efficitur turpis a nisi fringilla, at vestibulum lorem cursus. Suspendisse potenti. Nulla facilisi. Vivamus ac dui non odio aliquam gravida.", "Admin Test", new DateTime(2024, 3, 18, 16, 57, 17, 745, DateTimeKind.Local).AddTicks(6663), null, null, new Guid("3bd041f8-a798-4b61-adc3-669191a54d9b"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 },
                    { new Guid("b99acc67-61c1-431c-b6ec-2dcaa8a05a20"), new Guid("d8f762d7-d360-4573-a717-eacafef67266"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ac justo eget leo fringilla suscipit. Nullam vitae sapien vel ligula ultrices fermentum. Phasellus sollicitudin, nisi a fermentum convallis, eros dui varius ex, sed hendrerit ligula nisi eget magna. Integer posuere nibh at sem faucibus, in accumsan quam efficitur. Vivamus nec mi nec dolor fermentum aliquam. Duis ullamcorper feugiat magna, a suscipit metus mattis nec. Quisque sed velit quis nisi convallis feugiat nec eu lacus. Proin id ipsum sit amet magna consequat aliquet. Ut viverra magna in erat laoreet, ac lacinia ipsum luctus. Nam sodales convallis aliquam. Morbi in libero urna. Fusce sed est a nulla tincidunt tempus non eu odio. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer efficitur turpis a nisi fringilla, at vestibulum lorem cursus. Suspendisse potenti. Nulla facilisi. Vivamus ac dui non odio aliquam gravida.", "Admin Test", new DateTime(2024, 3, 18, 16, 57, 17, 745, DateTimeKind.Local).AddTicks(6656), null, null, new Guid("24760b47-f5ae-4cf6-bfee-b17fcab0e9f1"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("811b6955-ab4d-4c07-9887-44905e5cdd74"), "61cea6e4-16fe-4751-83ff-bf637567cea0", "Admin", "ADMIN" },
                    { new Guid("a50a6928-fe5b-4895-b570-ebca1fee4140"), "5d5c1c23-a1ad-4ff7-8305-bf9c87340fab", "SuperAdmin", "SUPERADMIN" },
                    { new Guid("b1680377-ab78-4596-9e95-05027562f714"), "e4a75542-b23e-4a36-aaa5-22a4b5d8c5ff", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("66d01b81-288c-44aa-a8b1-b021d7041af5"), 0, "979b732c-3f3d-4f0c-bc8d-1e06032d3b48", "superadmin@gmail.com", true, "Burak", "Cevizli", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAENjtLWIY+qqrrh8chNXKnic49xZ9gMcdAPdQTBptm1w9fvszlB7zPZ7meINtIFJJ1g==", "+905533454545", true, "6a1f5277-9ed9-4d1d-b942-31dce3767c58", false, "superadmin@gmail.com" },
                    { new Guid("8de8558e-a1f2-40c2-8481-770d75a8f88a"), 0, "64e816f0-5055-47ad-9c10-d4c4da2a9be0", "admin@gmail.com", false, "Admin", "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEL4vmLcy7I9S2okb1jBbivBdC44sY6pjgzCkk6tmShxi1COtxWW5bB0l2JzU5Pjy/g==", "+905533566666", false, "9907db32-7b58-41ac-95a5-026cf8789316", false, "admin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d8f762d7-d360-4573-a717-eacafef67266"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 16, 57, 17, 745, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd18e57b-2b39-4768-a1f3-2300c7c2069a"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 16, 57, 17, 745, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("24760b47-f5ae-4cf6-bfee-b17fcab0e9f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 16, 57, 17, 745, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3bd041f8-a798-4b61-adc3-669191a54d9b"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 18, 16, 57, 17, 745, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("a50a6928-fe5b-4895-b570-ebca1fee4140"), new Guid("66d01b81-288c-44aa-a8b1-b021d7041af5") },
                    { new Guid("811b6955-ab4d-4c07-9887-44905e5cdd74"), new Guid("8de8558e-a1f2-40c2-8481-770d75a8f88a") }
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
        }

        /// <inheritdoc />
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("48407d35-45cb-4e4c-8cda-d7244a486390"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b99acc67-61c1-431c-b6ec-2dcaa8a05a20"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedTime", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("a7ad864e-2ed0-4617-951f-04f72b409d9a"), new Guid("d8f762d7-d360-4573-a717-eacafef67266"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ac justo eget leo fringilla suscipit. Nullam vitae sapien vel ligula ultrices fermentum. Phasellus sollicitudin, nisi a fermentum convallis, eros dui varius ex, sed hendrerit ligula nisi eget magna. Integer posuere nibh at sem faucibus, in accumsan quam efficitur. Vivamus nec mi nec dolor fermentum aliquam. Duis ullamcorper feugiat magna, a suscipit metus mattis nec. Quisque sed velit quis nisi convallis feugiat nec eu lacus. Proin id ipsum sit amet magna consequat aliquet. Ut viverra magna in erat laoreet, ac lacinia ipsum luctus. Nam sodales convallis aliquam. Morbi in libero urna. Fusce sed est a nulla tincidunt tempus non eu odio. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer efficitur turpis a nisi fringilla, at vestibulum lorem cursus. Suspendisse potenti. Nulla facilisi. Vivamus ac dui non odio aliquam gravida.", "Admin Test", new DateTime(2024, 3, 14, 23, 9, 39, 843, DateTimeKind.Local).AddTicks(861), null, null, new Guid("24760b47-f5ae-4cf6-bfee-b17fcab0e9f1"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 },
                    { new Guid("eaf49916-65e7-416c-8287-d147937c832f"), new Guid("fd18e57b-2b39-4768-a1f3-2300c7c2069a"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ac justo eget leo fringilla suscipit. Nullam vitae sapien vel ligula ultrices fermentum. Phasellus sollicitudin, nisi a fermentum convallis, eros dui varius ex, sed hendrerit ligula nisi eget magna. Integer posuere nibh at sem faucibus, in accumsan quam efficitur. Vivamus nec mi nec dolor fermentum aliquam. Duis ullamcorper feugiat magna, a suscipit metus mattis nec. Quisque sed velit quis nisi convallis feugiat nec eu lacus. Proin id ipsum sit amet magna consequat aliquet. Ut viverra magna in erat laoreet, ac lacinia ipsum luctus. Nam sodales convallis aliquam. Morbi in libero urna. Fusce sed est a nulla tincidunt tempus non eu odio. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer efficitur turpis a nisi fringilla, at vestibulum lorem cursus. Suspendisse potenti. Nulla facilisi. Vivamus ac dui non odio aliquam gravida.", "Admin Test", new DateTime(2024, 3, 14, 23, 9, 39, 843, DateTimeKind.Local).AddTicks(879), null, null, new Guid("3bd041f8-a798-4b61-adc3-669191a54d9b"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d8f762d7-d360-4573-a717-eacafef67266"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 14, 23, 9, 39, 843, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd18e57b-2b39-4768-a1f3-2300c7c2069a"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 14, 23, 9, 39, 843, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("24760b47-f5ae-4cf6-bfee-b17fcab0e9f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 14, 23, 9, 39, 843, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3bd041f8-a798-4b61-adc3-669191a54d9b"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 14, 23, 9, 39, 843, DateTimeKind.Local).AddTicks(2889));
        }
    }
}
