using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Biblioteca.Domain.Entities;

public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("USUARIOS");

        builder.HasKey(u => u.UsuarioId);

        builder.Property(u => u.UsuarioNome)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.UsuarioEmail)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(u => u.UsuarioCpf)
            .IsRequired()
            .HasMaxLength(11);

        builder.HasIndex(u => u.UsuarioEmail).IsUnique();
        builder.HasIndex(u => u.UsuarioCpf).IsUnique();
    }
}