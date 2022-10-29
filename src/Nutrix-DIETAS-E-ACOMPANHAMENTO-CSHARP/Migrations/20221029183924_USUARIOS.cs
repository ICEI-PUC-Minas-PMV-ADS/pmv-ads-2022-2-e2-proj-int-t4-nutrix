using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Migrations
{
    public partial class USUARIOS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmacaoSenha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNasc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SexoBiologico = table.Column<string>(type: "VARCHAR(1)", maxLength: 1, nullable: true),
                    IsDiabetico = table.Column<bool>(type: "bit", nullable: false),
                    IsIntoleranteLactose = table.Column<bool>(type: "bit", nullable: false),
                    IsAlergicoGluten = table.Column<bool>(type: "bit", nullable: false),
                    IsAlergicoFrutosMar = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
