namespace Biblioteca.Domain.Entities;

public class Feedback
{
    public int FeedbackId { get; set; }

    public int FeedbackNota { get; set; }

    public string FeedbackDescricao { get; set; }

    public int LivroId { get; set; }
}