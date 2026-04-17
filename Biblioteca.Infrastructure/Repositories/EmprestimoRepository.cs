using Microsoft.EntityFrameworkCore;
using Biblioteca.Application.Interfaces;
using Biblioteca.Domain.Entities;

namespace Biblioteca.Infrastructure.Repositories;

public class EmprestimoRepository : IEmprestimoRepository
{
    private readonly BibliotecaContext _context;

    public EmprestimoRepository(BibliotecaContext context)
    {
        _context = context;
    }

    public async Task<Emprestimo?> ObterPorIdAsync(int id)
    {
        return await _context.Emprestimos.FindAsync(id);
    }

    public async Task<IEnumerable<Emprestimo>> ObterTodosAsync()
    {
        return await _context.Emprestimos.ToListAsync();
    }

    public async Task AdicionarAsync(Emprestimo emprestimo)
    {
        await _context.Emprestimos.AddAsync(emprestimo);
        await _context.SaveChangesAsync();
    }

    public async Task AtualizarAsync(Emprestimo emprestimo)
    {
        _context.Emprestimos.Update(emprestimo);
        await _context.SaveChangesAsync();
    }

    public async Task RemoverAsync(int id)
    {
        var emprestimo = await _context.Emprestimos.FindAsync(id);
        if (emprestimo != null)
        {
            _context.Emprestimos.Remove(emprestimo);
            await _context.SaveChangesAsync();
        }
    }
}
