using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pivot.Infra.Data.Migrations
{
    public partial class AdicionaMarca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    UsuarioCriacaoId = table.Column<int>(nullable: false),
                    UsuarioCriacaoLogin = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    UsuarioAlteracaoId = table.Column<int>(nullable: false),
                    UsuarioAlteracaoLogin = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    AtividadeId = table.Column<long>(nullable: false),
                    RepresentanteId = table.Column<long>(nullable: false),
                    PricePoint = table.Column<int>(nullable: false),
                    FaixaEtaria = table.Column<int>(nullable: false),
                    Abrangencia = table.Column<int>(nullable: false),
                    ModeloOperacional = table.Column<int>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    Logo = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    MarcaAgrupadaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marca_Marca_MarcaAgrupadaId",
                        column: x => x.MarcaAgrupadaId,
                        principalTable: "Marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Marca_Marca_RepresentanteId",
                        column: x => x.RepresentanteId,
                        principalTable: "Marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Marca_MarcaAgrupadaId",
                table: "Marca",
                column: "MarcaAgrupadaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Marca_RepresentanteId",
                table: "Marca",
                column: "RepresentanteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marca");
        }
    }
}
