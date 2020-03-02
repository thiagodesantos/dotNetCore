using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pivot.Infra.Data.Migrations
{
    public partial class AdicionarTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estado",
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
                    Sigla = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grafia",
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
                    MarcaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grafia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grafia_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ramo",
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
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ramo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
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
                    EstadoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cidade_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Atividade",
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
                    RamoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atividade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atividade_Ramo_RamoId",
                        column: x => x.RamoId,
                        principalTable: "Ramo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
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
                    Nome = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: true),
                    CidadeId = table.Column<long>(nullable: false),
                    MarcaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contato_Cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contato_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Email",
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
                    Endereco = table.Column<string>(nullable: true),
                    ContatoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Email_Contato_ContatoId",
                        column: x => x.ContatoId,
                        principalTable: "Contato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
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
                    Numero = table.Column<string>(nullable: true),
                    ContatoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefone_Contato_ContatoId",
                        column: x => x.ContatoId,
                        principalTable: "Contato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Marca_AtividadeId",
                table: "Marca",
                column: "AtividadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Atividade_RamoId",
                table: "Atividade",
                column: "RamoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_EstadoId",
                table: "Cidade",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_CidadeId",
                table: "Contato",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_MarcaId",
                table: "Contato",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Email_ContatoId",
                table: "Email",
                column: "ContatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Grafia_MarcaId",
                table: "Grafia",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_ContatoId",
                table: "Telefone",
                column: "ContatoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Marca_Atividade_AtividadeId",
                table: "Marca",
                column: "AtividadeId",
                principalTable: "Atividade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marca_Atividade_AtividadeId",
                table: "Marca");

            migrationBuilder.DropTable(
                name: "Atividade");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "Grafia");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "Ramo");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropIndex(
                name: "IX_Marca_AtividadeId",
                table: "Marca");
        }
    }
}
