using Microsoft.EntityFrameworkCore.Migrations;

namespace Deep_Sales.Migrations
{
    public partial class category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "ApplicationUserId", "CategoryName" },
                values: new object[] { 6, null, "Other" });

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_UserId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_AspNetUsers_UserId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_UserId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Comment_UserId",
                table: "Comment");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Product",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Comment",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Comment",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a719a4c3-00ec-4181-ac1f-b51959409710", "AQAAAAEAACcQAAAAEMJQcHpfb+wdxi88+U68ChhedvxuQjTacvMzHAJDhMuq0ITjjh5OPWdzvw7V+t14xg==" });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ApplicationUserId",
                table: "Product",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ApplicationUserId",
                table: "Comment",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_ApplicationUserId",
                table: "Comment",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_AspNetUsers_ApplicationUserId",
                table: "Product",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
