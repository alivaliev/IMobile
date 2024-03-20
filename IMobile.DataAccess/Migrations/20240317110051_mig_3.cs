using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMobile.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryLanguage_Categories_CategoryId",
                table: "CategoryLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_Picture_Products_ProductId",
                table: "Picture");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLanguage_Products_ProductId",
                table: "ProductLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Specifications_Products_ProductId",
                table: "Specifications");

            migrationBuilder.DropIndex(
                name: "IX_Specifications_ProductId",
                table: "Specifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductLanguage",
                table: "ProductLanguage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Picture",
                table: "Picture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryLanguage",
                table: "CategoryLanguage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Specifications");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Specifications");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Specifications");

            migrationBuilder.RenameTable(
                name: "ProductLanguage",
                newName: "ProductLanguages");

            migrationBuilder.RenameTable(
                name: "Picture",
                newName: "Pictures");

            migrationBuilder.RenameTable(
                name: "CategoryLanguage",
                newName: "CategoryLanguages");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_ProductLanguage_ProductId",
                table: "ProductLanguages",
                newName: "IX_ProductLanguages_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Picture_ProductId",
                table: "Pictures",
                newName: "IX_Pictures_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryLanguage_CategoryId",
                table: "CategoryLanguages",
                newName: "IX_CategoryLanguages_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductLanguages",
                table: "ProductLanguages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pictures",
                table: "Pictures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryLanguages",
                table: "CategoryLanguages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SpecificationLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificationLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecificationLanguages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpecificationLanguages_ProductId",
                table: "SpecificationLanguages",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryLanguages_Category_CategoryId",
                table: "CategoryLanguages",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Products_ProductId",
                table: "Pictures",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLanguages_Products_ProductId",
                table: "ProductLanguages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryLanguages_Category_CategoryId",
                table: "CategoryLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Products_ProductId",
                table: "Pictures");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLanguages_Products_ProductId",
                table: "ProductLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "SpecificationLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductLanguages",
                table: "ProductLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pictures",
                table: "Pictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryLanguages",
                table: "CategoryLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "ProductLanguages",
                newName: "ProductLanguage");

            migrationBuilder.RenameTable(
                name: "Pictures",
                newName: "Picture");

            migrationBuilder.RenameTable(
                name: "CategoryLanguages",
                newName: "CategoryLanguage");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_ProductLanguages_ProductId",
                table: "ProductLanguage",
                newName: "IX_ProductLanguage_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Pictures_ProductId",
                table: "Picture",
                newName: "IX_Picture_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryLanguages_CategoryId",
                table: "CategoryLanguage",
                newName: "IX_CategoryLanguage_CategoryId");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Specifications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Specifications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "Specifications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductLanguage",
                table: "ProductLanguage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Picture",
                table: "Picture",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryLanguage",
                table: "CategoryLanguage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Specifications_ProductId",
                table: "Specifications",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryLanguage_Categories_CategoryId",
                table: "CategoryLanguage",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Picture_Products_ProductId",
                table: "Picture",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLanguage_Products_ProductId",
                table: "ProductLanguage",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specifications_Products_ProductId",
                table: "Specifications",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
