using Biblioteca.Domain.Entities;

namespace Biblioteca.Application.Interfaces;

public interface IEmprestimoRepository
{
    Task<Emprestimo?> ObterPorIdAsync(int id);
    Task<IEnumerable<Emprestimo>> ObterTodosAsync();
    Task AdicionarAsync(Emprestimo emprestimo);
    Task AtualizarAsync(Emprestimo emprestimo);
    Task RemoverAsync(int id);
}
