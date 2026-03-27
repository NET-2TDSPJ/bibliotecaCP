using Microsoft.EntityFrameworkCore;
using Biblioteca.Domain;

public class BibliotecaContext : DbContext
{
    public DbSet<Livro> Livros { get; set; }

    public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
        : base(options)
    {
    }
}