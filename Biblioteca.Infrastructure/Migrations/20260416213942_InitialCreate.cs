using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORIAS",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CategoriaNome = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    CategoriaDescricao = table.Column<string>(type: "NVARCHAR2(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIAS", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "LIVROS",
                columns: table => new
                {
                    LivroId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LivroTitulo = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    LivroAutor = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    LivroStatus = table.Column<string>(type: "NVARCHAR2(1)", maxLength: 1, nullable: false),
                    LivroQtdPaginas = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    LivroAnoPublicacao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIVROS", x => x.LivroId);
                });

            migrationBuilder.CreateTable(
                name: "USUARIOS",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    UsuarioNome = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    UsuarioEmail = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    UsuarioCpf = table.Column<string>(type: "NVARCHAR2(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "CATEGORIAS_LIVROS",
                columns: table => new
                {
                    CategoriaLivroId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CategoriaId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    LivroId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIAS_LIVROS", x => x.CategoriaLivroId);
                    table.ForeignKey(
                        name: "FK_CATEGORIAS_LIVROS_CATEGORIAS_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "CATEGORIAS",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CATEGORIAS_LIVROS_LIVROS_LivroId",
                        column: x => x.LivroId,
                        principalTable: "LIVROS",
                        principalColumn: "LivroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FEEDBACKS",
                columns: table => new
                {
                    FeedbackId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    FeedbackNota = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    FeedbackDescricao = table.Column<string>(type: "NVARCHAR2(500)", maxLength: 500, nullable: false),
                    LivroId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FEEDBACKS", x => x.FeedbackId);
                    table.ForeignKey(
                        name: "FK_FEEDBACKS_LIVROS_LivroId",
                        column: x => x.LivroId,
                        principalTable: "LIVROS",
                        principalColumn: "LivroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EMPRESTIMOS",
                columns: table => new
                {
                    EmprestimoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    EmprestimoData = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    EmprestimoStatus = table.Column<string>(type: "NVARCHAR2(1)", maxLength: 1, nullable: false),
                    EmprestimoDevolucao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    EmprestimoDevolucaoPrevista = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LivroId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    UsuarioId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPRESTIMOS", x => x.EmprestimoId);
                    table.ForeignKey(
                        name: "FK_EMPRESTIMOS_LIVROS_LivroId",
                        column: x => x.LivroId,
                        principalTable: "LIVROS",
                        principalColumn: "LivroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EMPRESTIMOS_USUARIOS_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "USUARIOS",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CATEGORIAS_LIVROS_CategoriaId",
                table: "CATEGORIAS_LIVROS",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_CATEGORIAS_LIVROS_LivroId",
                table: "CATEGORIAS_LIVROS",
                column: "LivroId");

            migrationBuilder.CreateIndex(
                name: "IX_EMPRESTIMOS_LivroId",
                table: "EMPRESTIMOS",
                column: "LivroId");

            migrationBuilder.CreateIndex(
                name: "IX_EMPRESTIMOS_UsuarioId",
                table: "EMPRESTIMOS",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_FEEDBACKS_LivroId",
                table: "FEEDBACKS",
                column: "LivroId");

            migrationBuilder.CreateIndex(
                name: "IX_USUARIOS_UsuarioCpf",
                table: "USUARIOS",
                column: "UsuarioCpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_USUARIOS_UsuarioEmail",
                table: "USUARIOS",
                column: "UsuarioEmail",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CATEGORIAS_LIVROS");

            migrationBuilder.DropTable(
                name: "EMPRESTIMOS");

            migrationBuilder.DropTable(
                name: "FEEDBACKS");

            migrationBuilder.DropTable(
                name: "CATEGORIAS");

            migrationBuilder.DropTable(
                name: "USUARIOS");

            migrationBuilder.DropTable(
                name: "LIVROS");
        }
    }
}
