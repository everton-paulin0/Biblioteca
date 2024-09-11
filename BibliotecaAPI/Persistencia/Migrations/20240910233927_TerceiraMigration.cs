using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BibliotecaAPI.Persistencia.Migrations
{
    /// <inheritdoc />
    public partial class TerceiraMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComentariosLivros_Usuarios_UsuariosId",
                table: "ComentariosLivros");

            migrationBuilder.DropIndex(
                name: "IX_ComentariosLivros_UsuariosId",
                table: "ComentariosLivros");

            migrationBuilder.DropColumn(
                name: "UsuariosId",
                table: "ComentariosLivros");

            migrationBuilder.CreateIndex(
                name: "IX_ComentariosLivros_IdUsuario",
                table: "ComentariosLivros",
                column: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_ComentariosLivros_Usuarios_IdUsuario",
                table: "ComentariosLivros",
                column: "IdUsuario",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComentariosLivros_Usuarios_IdUsuario",
                table: "ComentariosLivros");

            migrationBuilder.DropIndex(
                name: "IX_ComentariosLivros_IdUsuario",
                table: "ComentariosLivros");

            migrationBuilder.AddColumn<int>(
                name: "UsuariosId",
                table: "ComentariosLivros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ComentariosLivros_UsuariosId",
                table: "ComentariosLivros",
                column: "UsuariosId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComentariosLivros_Usuarios_UsuariosId",
                table: "ComentariosLivros",
                column: "UsuariosId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
