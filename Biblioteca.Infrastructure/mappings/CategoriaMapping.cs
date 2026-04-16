using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Biblioteca.Domain.Entities;

public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        builder.ToTable("CATEGORIAS");

        builder.HasKey(c => c.CategoriaId);

        builder.Property(c => c.CategoriaNome)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(c => c.CategoriaDescricao)
            .HasMaxLength(500);
    }
}