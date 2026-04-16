using Microsoft.EntityFrameworkCore;
using Biblioteca.Domain.Entities;

namespace Biblioteca.Infrastructure;

public class BibliotecaContext : DbContext
{
    public DbSet<Livro> Livros { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<CategoriaLivro> CategoriasLivros { get; set; }
    public DbSet<Emprestimo> Emprestimos { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }

    public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BibliotecaContext).Assembly);
    }
}