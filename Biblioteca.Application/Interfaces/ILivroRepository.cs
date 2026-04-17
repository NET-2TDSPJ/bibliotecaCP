using Biblioteca.Domain.Entities;

namespace Biblioteca.Application.Interfaces;

public interface ILivroRepository
{
    Task<Livro?> ObterPorIdAsync(int id);
    Task<IEnumerable<Livro>> ObterTodosAsync();
    Task AdicionarAsync(Livro livro);
    Task AtualizarAsync(Livro livro);
    Task RemoverAsync(int id);
}
