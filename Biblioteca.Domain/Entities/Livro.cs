namespace Biblioteca.Domain.Entities;

public class Livro
{
    public int LivroId { get; set; }
    public string LivroTitulo { get; set; }
    public string LivroAutor { get; set; }
    public string LivroStatus { get; set; }
    public int LivroQtdPaginas { get; set; }
    public DateTime LivroAnoPublicacao { get; set; }

    public ICollection<Emprestimo> Emprestimos { get; set; }
    public ICollection<Feedback> Feedbacks { get; set; }
    public ICollection<CategoriaLivro> CategoriasLivros { get; set; }
}