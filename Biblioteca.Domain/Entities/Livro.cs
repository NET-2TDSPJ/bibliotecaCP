namespace Biblioteca.Domain.Entities;

public class Livro
{
    public int LivroId { get; set; }

    public string LivroTitulo { get; set; } = string.Empty;

    public string LivroAutor { get; set; } = string.Empty;

    public char LivroStatus { get; set; }

    public int LivroQtdPaginas { get; set; }

    public DateTime LivroAnoPublicacao { get; set; }
}