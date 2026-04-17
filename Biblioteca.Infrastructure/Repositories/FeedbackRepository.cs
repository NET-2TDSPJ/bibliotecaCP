using Microsoft.EntityFrameworkCore;
using Biblioteca.Application.Interfaces;
using Biblioteca.Domain.Entities;

namespace Biblioteca.Infrastructure.Repositories;

public class FeedbackRepository : IFeedbackRepository
{
    private readonly BibliotecaContext _context;

    public FeedbackRepository(BibliotecaContext context)
    {
        _context = context;
    }

    public async Task<Feedback?> ObterPorIdAsync(int id)
    {
        return await _context.Feedbacks.FindAsync(id);
    }

    public async Task<IEnumerable<Feedback>> ObterTodosAsync()
    {
        return await _context.Feedbacks.ToListAsync();
    }

    public async Task AdicionarAsync(Feedback feedback)
    {
        await _context.Feedbacks.AddAsync(feedback);
        await _context.SaveChangesAsync();
    }

    public async Task AtualizarAsync(Feedback feedback)
    {
        _context.Feedbacks.Update(feedback);
        await _context.SaveChangesAsync();
    }

    public async Task RemoverAsync(int id)
    {
        var feedback = await _context.Feedbacks.FindAsync(id);
        if (feedback != null)
        {
            _context.Feedbacks.Remove(feedback);
            await _context.SaveChangesAsync();
        }
    }
}
