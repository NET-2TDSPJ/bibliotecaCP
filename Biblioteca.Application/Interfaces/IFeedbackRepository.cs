using Biblioteca.Domain.Entities;

namespace Biblioteca.Application.Interfaces;

public interface IFeedbackRepository
{
    Task<Feedback?> ObterPorIdAsync(int id);
    Task<IEnumerable<Feedback>> ObterTodosAsync();
    Task AdicionarAsync(Feedback feedback);
    Task AtualizarAsync(Feedback feedback);
    Task RemoverAsync(int id);
}
