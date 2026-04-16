public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("USUARIOS");

        builder.HasKey(u => u.UsuarioId);

        builder.Property(u => u.Nome)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(u => u.Cpf)
            .IsRequired()
            .HasMaxLength(11);

        builder.HasIndex(u => u.Email).IsUnique();
        builder.HasIndex(u => u.Cpf).IsUnique();
    }
}