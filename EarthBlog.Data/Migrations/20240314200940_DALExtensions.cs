using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EarthBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class DALExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("32df8302-a274-4561-8b95-62652ef20501"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("cbca7891-19ee-4b9a-8410-765b82b1925f"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a7ad864e-2ed0-4617-951f-04f72b409d9a"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("eaf49916-65e7-416c-8287-d147937c832f"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedTime", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("32df8302-a274-4561-8b95-62652ef20501"), new Guid("d8f762d7-d360-4573-a717-eacafef67266"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ac justo eget leo fringilla suscipit. Nullam vitae sapien vel ligula ultrices fermentum. Phasellus sollicitudin, nisi a fermentum convallis, eros dui varius ex, sed hendrerit ligula nisi eget magna. Integer posuere nibh at sem faucibus, in accumsan quam efficitur. Vivamus nec mi nec dolor fermentum aliquam. Duis ullamcorper feugiat magna, a suscipit metus mattis nec. Quisque sed velit quis nisi convallis feugiat nec eu lacus. Proin id ipsum sit amet magna consequat aliquet. Ut viverra magna in erat laoreet, ac lacinia ipsum luctus. Nam sodales convallis aliquam. Morbi in libero urna. Fusce sed est a nulla tincidunt tempus non eu odio. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer efficitur turpis a nisi fringilla, at vestibulum lorem cursus. Suspendisse potenti. Nulla facilisi. Vivamus ac dui non odio aliquam gravida.", "Admin Test", new DateTime(2024, 3, 14, 17, 10, 27, 681, DateTimeKind.Local).AddTicks(6352), null, null, new Guid("24760b47-f5ae-4cf6-bfee-b17fcab0e9f1"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 },
                    { new Guid("cbca7891-19ee-4b9a-8410-765b82b1925f"), new Guid("fd18e57b-2b39-4768-a1f3-2300c7c2069a"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ac justo eget leo fringilla suscipit. Nullam vitae sapien vel ligula ultrices fermentum. Phasellus sollicitudin, nisi a fermentum convallis, eros dui varius ex, sed hendrerit ligula nisi eget magna. Integer posuere nibh at sem faucibus, in accumsan quam efficitur. Vivamus nec mi nec dolor fermentum aliquam. Duis ullamcorper feugiat magna, a suscipit metus mattis nec. Quisque sed velit quis nisi convallis feugiat nec eu lacus. Proin id ipsum sit amet magna consequat aliquet. Ut viverra magna in erat laoreet, ac lacinia ipsum luctus. Nam sodales convallis aliquam. Morbi in libero urna. Fusce sed est a nulla tincidunt tempus non eu odio. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer efficitur turpis a nisi fringilla, at vestibulum lorem cursus. Suspendisse potenti. Nulla facilisi. Vivamus ac dui non odio aliquam gravida.", "Admin Test", new DateTime(2024, 3, 14, 17, 10, 27, 681, DateTimeKind.Local).AddTicks(6357), null, null, new Guid("3bd041f8-a798-4b61-adc3-669191a54d9b"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d8f762d7-d360-4573-a717-eacafef67266"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 14, 17, 10, 27, 681, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd18e57b-2b39-4768-a1f3-2300c7c2069a"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 14, 17, 10, 27, 681, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("24760b47-f5ae-4cf6-bfee-b17fcab0e9f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 14, 17, 10, 27, 681, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3bd041f8-a798-4b61-adc3-669191a54d9b"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 14, 17, 10, 27, 681, DateTimeKind.Local).AddTicks(8527));
        }
    }
}
