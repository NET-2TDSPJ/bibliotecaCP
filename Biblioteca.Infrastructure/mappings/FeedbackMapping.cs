public class FeedbackMapping : IEntityTypeConfiguration<Feedback>
{
    public void Configure(EntityTypeBuilder<Feedback> builder)
    {
        builder.ToTable("FEEDBACKS");

        builder.HasKey(f => f.FeedbackId);

        builder.Property(f => f.Nota)
            .IsRequired();

        builder.Property(f => f.Descricao)
            .HasMaxLength(500);

        builder.HasOne(f => f.Livro)
            .WithMany(l => l.Feedbacks)
            .HasForeignKey(f => f.LivroId);
    }
}