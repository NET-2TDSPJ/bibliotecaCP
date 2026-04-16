using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Biblioteca.Domain.Entities;

public class CategoriaLivroMapping : IEntityTypeConfiguration<CategoriaLivro>
{
    public void Configure(EntityTypeBuilder<CategoriaLivro> builder)
    {
        builder.ToTable("CATEGORIAS_LIVROS");

        builder.HasKey(cl => cl.CategoriaLivroId);

        builder.HasOne(cl => cl.Categoria)
            .WithMany(c => c.CategoriasLivros)
            .HasForeignKey(cl => cl.CategoriaId);

        builder.HasOne(cl => cl.Livro)
            .WithMany(l => l.CategoriasLivros)
            .HasForeignKey(cl => cl.LivroId);
    }
}