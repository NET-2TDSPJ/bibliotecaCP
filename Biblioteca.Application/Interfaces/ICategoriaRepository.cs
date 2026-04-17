using Biblioteca.Domain.Entities;

namespace Biblioteca.Application.Interfaces;

public interface ICategoriaRepository
{
    Task<Categoria?> ObterPorIdAsync(int id);
    Task<IEnumerable<Categoria>> ObterTodosAsync();
    Task AdicionarAsync(Categoria categoria);
    Task AtualizarAsync(Categoria categoria);
    Task RemoverAsync(int id);
}
