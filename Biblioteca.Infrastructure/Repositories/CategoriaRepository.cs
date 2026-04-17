using Microsoft.EntityFrameworkCore;
using Biblioteca.Application.Interfaces;
using Biblioteca.Domain.Entities;

namespace Biblioteca.Infrastructure.Repositories;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly BibliotecaContext _context;

    public CategoriaRepository(BibliotecaContext context)
    {
        _context = context;
    }

    public async Task<Categoria?> ObterPorIdAsync(int id)
    {
        return await _context.Categorias.FindAsync(id);
    }

    public async Task<IEnumerable<Categoria>> ObterTodosAsync()
    {
        return await _context.Categorias.ToListAsync();
    }

    public async Task AdicionarAsync(Categoria categoria)
    {
        await _context.Categorias.AddAsync(categoria);
        await _context.SaveChangesAsync();
    }

    public async Task AtualizarAsync(Categoria categoria)
    {
        _context.Categorias.Update(categoria);
        await _context.SaveChangesAsync();
    }

    public async Task RemoverAsync(int id)
    {
        var categoria = await _context.Categorias.FindAsync(id);
        if (categoria != null)
        {
            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();
        }
    }
}
