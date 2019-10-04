using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase.Migrations
{
    public partial class Base2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    SurName = table.Column<string>(nullable: true),
                    Patronymic = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Design",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Markup = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Design", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cake",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    DesigIDId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cake", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cake_Design_DesigIDId",
                        column: x => x.DesigIDId,
                        principalTable: "Design",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Blank",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IngredientIDId = table.Column<int>(nullable: true),
                    Weight = table.Column<int>(nullable: false),
                    CakeIDId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blank_Cake_CakeIDId",
                        column: x => x.CakeIDId,
                        principalTable: "Cake",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blank_Ingredient_IngredientIDId",
                        column: x => x.IngredientIDId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blank_CakeIDId",
                table: "Blank",
                column: "CakeIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Blank_IngredientIDId",
                table: "Blank",
                column: "IngredientIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Cake_DesigIDId",
                table: "Cake",
                column: "DesigIDId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blank");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Cake");

            migrationBuilder.DropTable(
                name: "Design");
        }
    }
}
