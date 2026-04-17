using Biblioteca.Domain.Entities;

namespace Biblioteca.Application.Interfaces;

public interface IUsuarioRepository
{
    Task<Usuario?> ObterPorIdAsync(int id);
    Task<IEnumerable<Usuario>> ObterTodosAsync();
    Task AdicionarAsync(Usuario usuario);
    Task AtualizarAsync(Usuario usuario);
    Task RemoverAsync(int id);
}
