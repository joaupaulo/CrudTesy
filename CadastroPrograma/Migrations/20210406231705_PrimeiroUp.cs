using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroPrograma.Migrations
{
    public partial class PrimeiroUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InfoProgramador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NumeroWhats = table.Column<int>(type: "int", maxLength: 21, nullable: false),
                    Linkedin = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Local = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Portifolio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorarioManha = table.Column<bool>(type: "bit", nullable: false),
                    HorarioNoite = table.Column<bool>(type: "bit", nullable: false),
                    HorarioMadrugada = table.Column<bool>(type: "bit", nullable: false),
                    HorarioTarde = table.Column<bool>(type: "bit", nullable: false),
                    HorarioComercial = table.Column<bool>(type: "bit", nullable: false),
                    Salario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoProgramador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InfoProgramadorId = table.Column<int>(type: "int", nullable: false),
                    Ionic = table.Column<int>(type: "int", nullable: false),
                    ReactJS = table.Column<int>(type: "int", nullable: false),
                    ReactNative = table.Column<int>(type: "int", nullable: false),
                    Android = table.Column<int>(type: "int", nullable: false),
                    Flutter = table.Column<int>(type: "int", nullable: false),
                    Swift = table.Column<int>(type: "int", nullable: false),
                    Ios = table.Column<int>(type: "int", nullable: false),
                    Html = table.Column<int>(type: "int", nullable: false),
                    Css = table.Column<int>(type: "int", nullable: false),
                    Bootstrap = table.Column<int>(type: "int", nullable: false),
                    Jquery = table.Column<int>(type: "int", nullable: false),
                    AngularJs1 = table.Column<int>(type: "int", nullable: false),
                    Angular = table.Column<int>(type: "int", nullable: false),
                    Java = table.Column<int>(type: "int", nullable: false),
                    Python = table.Column<int>(type: "int", nullable: false),
                    AspMvc = table.Column<int>(type: "int", nullable: false),
                    AspWebForm = table.Column<int>(type: "int", nullable: false),
                    C = table.Column<int>(type: "int", nullable: false),
                    Csharp = table.Column<int>(type: "int", nullable: false),
                    NodeJS = table.Column<int>(type: "int", nullable: false),
                    ExpressNode = table.Column<int>(type: "int", nullable: false),
                    Cake = table.Column<int>(type: "int", nullable: false),
                    Djanto = table.Column<int>(type: "int", nullable: false),
                    Majento = table.Column<int>(type: "int", nullable: false),
                    Php = table.Column<int>(type: "int", nullable: false),
                    Vue = table.Column<int>(type: "int", nullable: false),
                    Ruby = table.Column<int>(type: "int", nullable: false),
                    MySqlServer = table.Column<int>(type: "int", nullable: false),
                    MySql = table.Column<int>(type: "int", nullable: false),
                    Salesforce = table.Column<int>(type: "int", nullable: false),
                    Photoshop = table.Column<int>(type: "int", nullable: false),
                    Ilustrator = table.Column<int>(type: "int", nullable: false),
                    Seo = table.Column<int>(type: "int", nullable: false),
                    Laravel = table.Column<int>(type: "int", nullable: false),
                    Outros = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Habilidades_InfoProgramador_InfoProgramadorId",
                        column: x => x.InfoProgramadorId,
                        principalTable: "InfoProgramador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Habilidades_InfoProgramadorId",
                table: "Habilidades",
                column: "InfoProgramadorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropTable(
                name: "InfoProgramador");
        }
    }
}
