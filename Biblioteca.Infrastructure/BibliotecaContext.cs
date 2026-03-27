using Microsoft.EntityFrameworkCore;
using Biblioteca.Domain.Entities;

namespace Biblioteca.Infrastructure;

public class BibliotecaContext : DbContext
{
    public DbSet<Livro> Livros { get; set; }

    public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
        : base(options)
    {
    }
}