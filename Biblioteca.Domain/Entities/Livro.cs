namespace Biblioteca.Domain.Entities;

public class Livro
{
    public int LivroId { get; set; }

    public string LivroTitulo { get; set; }

    public string LivroAutor { get; set; }

    public char LivroStatus { get; set; }

    public int LivroQtdPaginas { get; set; }

    public DateTime LivroAnoPublicacao { get; set; }
}