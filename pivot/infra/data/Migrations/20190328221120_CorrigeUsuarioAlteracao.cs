using Microsoft.EntityFrameworkCore.Migrations;

namespace Pivot.Infra.Data.Migrations
{
    public partial class CorrigeUsuarioAlteracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UsuarioAlteracaoLogin",
                table: "Telefone",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioAlteracaoLogin",
                table: "Ramo",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioAlteracaoLogin",
                table: "Marca",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioAlteracaoLogin",
                table: "Grafia",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioAlteracaoLogin",
                table: "Estado",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioAlteracaoLogin",
                table: "Email",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioAlteracaoLogin",
                table: "Contato",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioAlteracaoLogin",
                table: "Cidade",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioAlteracaoLogin",
                table: "Atividade",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UsuarioAlteracaoLogin",
                table: "Telefone",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioAlteracaoLogin",
                table: "Ramo",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioAlteracaoLogin",
                table: "Marca",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioAlteracaoLogin",
                table: "Grafia",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioAlteracaoLogin",
                table: "Estado",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioAlteracaoLogin",
                table: "Email",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioAlteracaoLogin",
                table: "Contato",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioAlteracaoLogin",
                table: "Cidade",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioAlteracaoLogin",
                table: "Atividade",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
