using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Biblioteca.Domain.Entities;

public class LivroMapping : IEntityTypeConfiguration<Livro>
{
    public void Configure(EntityTypeBuilder<Livro> builder)
    {
        builder.ToTable("LIVROS");

        builder.HasKey(l => l.LivroId);

        builder.Property(l => l.LivroTitulo)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(l => l.LivroAutor)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(l => l.LivroStatus)
            .IsRequired()
            .HasMaxLength(1);

        builder.Property(l => l.LivroQtdPaginas)
            .IsRequired();

        builder.Property(l => l.LivroAnoPublicacao)
            .IsRequired();
    }
}