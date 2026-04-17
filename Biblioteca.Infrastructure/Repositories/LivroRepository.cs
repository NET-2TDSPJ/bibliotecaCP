using Microsoft.EntityFrameworkCore;
using Biblioteca.Application.Interfaces;
using Biblioteca.Domain.Entities;

namespace Biblioteca.Infrastructure.Repositories;

public class LivroRepository : ILivroRepository
{
    private readonly BibliotecaContext _context;

    public LivroRepository(BibliotecaContext context)
    {
        _context = context;
    }

    public async Task<Livro?> ObterPorIdAsync(int id)
    {
        return await _context.Livros.FindAsync(id);
    }

    public async Task<IEnumerable<Livro>> ObterTodosAsync()
    {
        return await _context.Livros.ToListAsync();
    }

    public async Task AdicionarAsync(Livro livro)
    {
        await _context.Livros.AddAsync(livro);
        await _context.SaveChangesAsync();
    }

    public async Task AtualizarAsync(Livro livro)
    {
        _context.Livros.Update(livro);
        await _context.SaveChangesAsync();
    }

    public async Task RemoverAsync(int id)
    {
        var livro = await _context.Livros.FindAsync(id);
        if (livro != null)
        {
            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();
        }
    }
}
