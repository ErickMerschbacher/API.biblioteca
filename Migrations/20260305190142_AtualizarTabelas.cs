using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.biblioteca.Migrations
{
    /// <inheritdoc />
    public partial class AtualizarTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    LivroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnoPublicacao = table.Column<int>(type: "int", nullable: false),
                    ISBN10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlCapa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Editora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edicao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneroId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LivroId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.LivroId);
                    table.ForeignKey(
                        name: "FK_Livros_Generos_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Generos",
                        principalColumn: "GeneroId");
                    table.ForeignKey(
                        name: "FK_Livros_Livros_LivroId1",
                        column: x => x.LivroId1,
                        principalTable: "Livros",
                        principalColumn: "LivroId");
                });

            migrationBuilder.CreateTable(
                name: "LivrosGeneros",
                columns: table => new
                {
                    LivroGeneroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LivroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GeneroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivrosGeneros", x => x.LivroGeneroId);
                    table.ForeignKey(
                        name: "FK_LivrosGeneros_Generos_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Generos",
                        principalColumn: "GeneroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivrosGeneros_Livros_LivroId",
                        column: x => x.LivroId,
                        principalTable: "Livros",
                        principalColumn: "LivroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livros_GeneroId",
                table: "Livros",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_LivroId1",
                table: "Livros",
                column: "LivroId1");

            migrationBuilder.CreateIndex(
                name: "IX_LivrosGeneros_GeneroId",
                table: "LivrosGeneros",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_LivrosGeneros_LivroId",
                table: "LivrosGeneros",
                column: "LivroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LivrosGeneros");

            migrationBuilder.DropTable(
                name: "Livros");
        }
    }
}
