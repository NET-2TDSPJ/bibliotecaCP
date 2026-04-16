using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Biblioteca.Domain.Entities;

public class EmprestimoMapping : IEntityTypeConfiguration<Emprestimo>
{
    public void Configure(EntityTypeBuilder<Emprestimo> builder)
    {
        builder.ToTable("EMPRESTIMOS");

        builder.HasKey(e => e.EmprestimoId);

        builder.Property(e => e.EmprestimoData)
            .IsRequired();

        builder.Property(e => e.EmprestimoStatus)
            .IsRequired()
            .HasMaxLength(1);

        builder.Property(e => e.EmprestimoDevolucao);

        builder.Property(e => e.EmprestimoDevolucaoPrevista)
            .IsRequired();

        builder.HasOne(e => e.Livro)
            .WithMany(l => l.Emprestimos)
            .HasForeignKey(e => e.LivroId);

        builder.HasOne(e => e.Usuario)
            .WithMany(u => u.Emprestimos)
            .HasForeignKey(e => e.UsuarioId);
    }
}