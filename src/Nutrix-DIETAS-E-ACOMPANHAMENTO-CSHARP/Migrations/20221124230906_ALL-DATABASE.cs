using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nutrix_DIETAS_E_ACOMPANHAMENTO_CSHARP.Migrations
{
    public partial class ALLDATABASE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alimentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qtde = table.Column<int>(type: "int", nullable: false),
                    Categoria = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Umidade = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    EnergiaKcal = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    EnergiaKj = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Proteina = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Lipideos = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Colesterol = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Carboidrato = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    FibraAlimentar = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Cinzas = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Calcio = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Magnesio = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Manganes = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Fosforo = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Ferro = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Sodio = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Potassio = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Cobre = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Zinco = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Retinol = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Re = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Rae = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Tiamina = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Riboflavina = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Piridoxina = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    Niacina = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false),
                    VitaminaC = table.Column<string>(type: "VARCHAR(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alimentos", x => x.Id);
                });

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
                    SexoBiologico = table.Column<int>(type: "int", nullable: false),
                    IsDiabetico = table.Column<bool>(type: "bit", nullable: false),
                    IsIntoleranteLactose = table.Column<bool>(type: "bit", nullable: false),
                    IsAlergicoGluten = table.Column<bool>(type: "bit", nullable: false),
                    IsAlergicoFrutosMar = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DadosPessoais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataFicha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    Altura = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosPessoais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DadosPessoais_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dietas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataDieta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TituloDieta = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    NumeroRefeicoes = table.Column<int>(type: "int", nullable: false),
                    Objetivo = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dietas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dietas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Refeicoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroRefeicao = table.Column<int>(type: "int", nullable: false),
                    DietaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refeicoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Refeicoes_Dietas_DietaId",
                        column: x => x.DietaId,
                        principalTable: "Dietas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefeicoesAlimentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefeicaoId = table.Column<int>(type: "int", nullable: false),
                    AlimentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefeicoesAlimentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefeicoesAlimentos_Alimentos_AlimentoId",
                        column: x => x.AlimentoId,
                        principalTable: "Alimentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RefeicoesAlimentos_Refeicoes_RefeicaoId",
                        column: x => x.RefeicaoId,
                        principalTable: "Refeicoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DadosPessoais_UsuarioId",
                table: "DadosPessoais",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Dietas_UsuarioId",
                table: "Dietas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Refeicoes_DietaId",
                table: "Refeicoes",
                column: "DietaId");

            migrationBuilder.CreateIndex(
                name: "IX_RefeicoesAlimentos_AlimentoId",
                table: "RefeicoesAlimentos",
                column: "AlimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_RefeicoesAlimentos_RefeicaoId",
                table: "RefeicoesAlimentos",
                column: "RefeicaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DadosPessoais");

            migrationBuilder.DropTable(
                name: "RefeicoesAlimentos");

            migrationBuilder.DropTable(
                name: "Alimentos");

            migrationBuilder.DropTable(
                name: "Refeicoes");

            migrationBuilder.DropTable(
                name: "Dietas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
