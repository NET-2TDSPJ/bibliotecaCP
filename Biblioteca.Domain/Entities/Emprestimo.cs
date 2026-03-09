namespace Biblioteca.Domain.Entities;

public class Emprestimo
{
    public int EmprestimoId { get; set; }

    public DateTime EmprestimoData { get; set; }

    public char EmprestimoStatus { get; set; }

    public DateTime EmprestimoDevolucao { get; set; }

    public DateTime EmprestimoDevolucaoPrevista { get; set; }

    public int LivroId { get; set; }

    public int UsuarioId { get; set; }
}