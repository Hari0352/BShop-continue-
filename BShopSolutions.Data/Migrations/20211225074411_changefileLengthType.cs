using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BShopSolutions.Data.Migrations
{
    public partial class changefileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDefualt",
                table: "ProductImages");

            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsDefault",
                table: "ProductImages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "b74f44fa-7661-40c2-9c09-272ced8bbf5f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "620355b5-f964-411a-bfe0-b121a3f4ec4a", "AQAAAAEAACcQAAAAECcHD2ul5MLMZYWPFhQnIuJ7ypQjqcahe69ZuNu6Ke76qu1bbQOdfpLxPa/hrBwT5g==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 12, 25, 14, 44, 11, 76, DateTimeKind.Local).AddTicks(7882));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDefault",
                table: "ProductImages");

            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<bool>(
                name: "IsDefualt",
                table: "ProductImages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "389a17d1-0309-4323-958f-222aef203a8c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a916cc69-f56b-499d-86c9-1daa9ba8bd64", "AQAAAAEAACcQAAAAEFTMOZH+8Inks7eJkBvorOpg+pQyt7qNHEDu28MKupYXMzDMzDAlGN6JGW9OriFCCg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 12, 25, 12, 52, 54, 963, DateTimeKind.Local).AddTicks(811));
        }
    }
}
