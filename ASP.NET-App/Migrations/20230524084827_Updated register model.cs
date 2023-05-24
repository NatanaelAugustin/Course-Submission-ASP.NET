using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET_App.Migrations
{
    /// <inheritdoc />
    public partial class Updatedregistermodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategoryEntity_Products_ProductArticleNumber",
                table: "ProductCategoryEntity");

            migrationBuilder.AlterColumn<string>(
                name: "ProductArticleNumber",
                table: "ProductCategoryEntity",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategoryEntity_Products_ProductArticleNumber",
                table: "ProductCategoryEntity",
                column: "ProductArticleNumber",
                principalTable: "Products",
                principalColumn: "ArticleNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategoryEntity_Products_ProductArticleNumber",
                table: "ProductCategoryEntity");

            migrationBuilder.AlterColumn<string>(
                name: "ProductArticleNumber",
                table: "ProductCategoryEntity",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategoryEntity_Products_ProductArticleNumber",
                table: "ProductCategoryEntity",
                column: "ProductArticleNumber",
                principalTable: "Products",
                principalColumn: "ArticleNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
