using Microsoft.EntityFrameworkCore.Migrations;

namespace Pivot.Infra.Data.Migrations
{
    public partial class safeDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Telefone",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Ramo",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Grafia",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Estado",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Email",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Contato",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Cidade",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Atividade",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Telefone");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Ramo");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Grafia");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Estado");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Email");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Contato");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Cidade");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Atividade");
        }
    }
}
