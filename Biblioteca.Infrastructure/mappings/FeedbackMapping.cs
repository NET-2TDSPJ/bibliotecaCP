using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Biblioteca.Domain.Entities;

public class FeedbackMapping : IEntityTypeConfiguration<Feedback>
{
    public void Configure(EntityTypeBuilder<Feedback> builder)
    {
        builder.ToTable("FEEDBACKS");

        builder.HasKey(f => f.FeedbackId);

        builder.Property(f => f.FeedbackNota)
            .IsRequired();

        builder.Property(f => f.FeedbackDescricao)
            .HasMaxLength(500);

        builder.HasOne(f => f.Livro)
            .WithMany(l => l.Feedbacks)
            .HasForeignKey(f => f.LivroId);
    }
}