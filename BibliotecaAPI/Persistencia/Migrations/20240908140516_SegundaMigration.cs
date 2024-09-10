using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BibliotecaAPI.Persistencia.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Usuarios_UsuarioId",
                table: "Livros");

            migrationBuilder.DropIndex(
                name: "IX_Livros_UsuarioId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Livros");

            migrationBuilder.AddColumn<int>(
                name: "LivroId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "ComentariosLivros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_LivroId",
                table: "Usuarios",
                column: "LivroId");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_IdUsuario",
                table: "Livros",
                column: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Usuarios_IdUsuario",
                table: "Livros",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Livros_LivroId",
                table: "Usuarios",
                column: "LivroId",
                principalTable: "Livros",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Usuarios_IdUsuario",
                table: "Livros");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Livros_LivroId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_LivroId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Livros_IdUsuario",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "LivroId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "ComentariosLivros");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Livros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Livros_UsuarioId",
                table: "Livros",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Usuarios_UsuarioId",
                table: "Livros",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
