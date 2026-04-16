public class LivroMapping : IEntityTypeConfiguration<Livro>
{
    public void Configure(EntityTypeBuilder<Livro> builder)
    {
        builder.ToTable("LIVROS");

        builder.HasKey(l => l.LivroId);

        builder.Property(l => l.Titulo)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(l => l.Autor)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(l => l.Status)
            .IsRequired()
            .HasMaxLength(1);

        builder.Property(l => l.QtdPaginas)
            .IsRequired();

        builder.Property(l => l.AnoPublicacao)
            .IsRequired();
    }
}