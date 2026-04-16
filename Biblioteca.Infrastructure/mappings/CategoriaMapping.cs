public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        builder.ToTable("CATEGORIAS");

        builder.HasKey(c => c.CategoriaId);

        builder.Property(c => c.Nome)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(c => c.Descricao)
            .HasMaxLength(500);
    }
}