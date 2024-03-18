using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EarthBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedTime", "Name" },
                values: new object[,]
                {
                    { new Guid("d8f762d7-d360-4573-a717-eacafef67266"), "Admin Test", new DateTime(2024, 3, 14, 17, 10, 27, 681, DateTimeKind.Local).AddTicks(7521), null, null, false, null, null, "ASP.NET CORE" },
                    { new Guid("fd18e57b-2b39-4768-a1f3-2300c7c2069a"), "Admin Test", new DateTime(2024, 3, 14, 17, 10, 27, 681, DateTimeKind.Local).AddTicks(7543), null, null, false, null, null, "Visual Studio 2024" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("24760b47-f5ae-4cf6-bfee-b17fcab0e9f1"), "Admin Test", new DateTime(2024, 3, 14, 17, 10, 27, 681, DateTimeKind.Local).AddTicks(8524), null, null, "images/testimage", "jpg", false, null, null },
                    { new Guid("3bd041f8-a798-4b61-adc3-669191a54d9b"), "Admin Test", new DateTime(2024, 3, 14, 17, 10, 27, 681, DateTimeKind.Local).AddTicks(8527), null, null, "images/vstest", "png", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedTime", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("32df8302-a274-4561-8b95-62652ef20501"), new Guid("d8f762d7-d360-4573-a717-eacafef67266"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ac justo eget leo fringilla suscipit. Nullam vitae sapien vel ligula ultrices fermentum. Phasellus sollicitudin, nisi a fermentum convallis, eros dui varius ex, sed hendrerit ligula nisi eget magna. Integer posuere nibh at sem faucibus, in accumsan quam efficitur. Vivamus nec mi nec dolor fermentum aliquam. Duis ullamcorper feugiat magna, a suscipit metus mattis nec. Quisque sed velit quis nisi convallis feugiat nec eu lacus. Proin id ipsum sit amet magna consequat aliquet. Ut viverra magna in erat laoreet, ac lacinia ipsum luctus. Nam sodales convallis aliquam. Morbi in libero urna. Fusce sed est a nulla tincidunt tempus non eu odio. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer efficitur turpis a nisi fringilla, at vestibulum lorem cursus. Suspendisse potenti. Nulla facilisi. Vivamus ac dui non odio aliquam gravida.", "Admin Test", new DateTime(2024, 3, 14, 17, 10, 27, 681, DateTimeKind.Local).AddTicks(6352), null, null, new Guid("24760b47-f5ae-4cf6-bfee-b17fcab0e9f1"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 },
                    { new Guid("cbca7891-19ee-4b9a-8410-765b82b1925f"), new Guid("fd18e57b-2b39-4768-a1f3-2300c7c2069a"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ac justo eget leo fringilla suscipit. Nullam vitae sapien vel ligula ultrices fermentum. Phasellus sollicitudin, nisi a fermentum convallis, eros dui varius ex, sed hendrerit ligula nisi eget magna. Integer posuere nibh at sem faucibus, in accumsan quam efficitur. Vivamus nec mi nec dolor fermentum aliquam. Duis ullamcorper feugiat magna, a suscipit metus mattis nec. Quisque sed velit quis nisi convallis feugiat nec eu lacus. Proin id ipsum sit amet magna consequat aliquet. Ut viverra magna in erat laoreet, ac lacinia ipsum luctus. Nam sodales convallis aliquam. Morbi in libero urna. Fusce sed est a nulla tincidunt tempus non eu odio. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer efficitur turpis a nisi fringilla, at vestibulum lorem cursus. Suspendisse potenti. Nulla facilisi. Vivamus ac dui non odio aliquam gravida.", "Admin Test", new DateTime(2024, 3, 14, 17, 10, 27, 681, DateTimeKind.Local).AddTicks(6357), null, null, new Guid("3bd041f8-a798-4b61-adc3-669191a54d9b"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("32df8302-a274-4561-8b95-62652ef20501"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("cbca7891-19ee-4b9a-8410-765b82b1925f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d8f762d7-d360-4573-a717-eacafef67266"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd18e57b-2b39-4768-a1f3-2300c7c2069a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("24760b47-f5ae-4cf6-bfee-b17fcab0e9f1"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3bd041f8-a798-4b61-adc3-669191a54d9b"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
