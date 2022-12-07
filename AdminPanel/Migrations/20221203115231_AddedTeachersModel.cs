using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdminPanel.Migrations
{
    public partial class AddedTeachersModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewsPictures_Teachers_TeachersId",
                table: "NewsPictures");

            migrationBuilder.DropIndex(
                name: "IX_NewsPictures_TeachersId",
                table: "NewsPictures");

            migrationBuilder.DropColumn(
                name: "TeachersId",
                table: "NewsPictures");

            migrationBuilder.CreateTable(
                name: "TeachersPicture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Path = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TeachersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachersPicture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeachersPicture_Teachers_TeachersId",
                        column: x => x.TeachersId,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_TeachersPicture_TeachersId",
                table: "TeachersPicture",
                column: "TeachersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeachersPicture");

            migrationBuilder.AddColumn<int>(
                name: "TeachersId",
                table: "NewsPictures",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NewsPictures_TeachersId",
                table: "NewsPictures",
                column: "TeachersId");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsPictures_Teachers_TeachersId",
                table: "NewsPictures",
                column: "TeachersId",
                principalTable: "Teachers",
                principalColumn: "Id");
        }
    }
}
