namespace Biblioteca.Domain.Entities;

public class Categoria
{
    public int CategoriaId { get; set; }

    public string CategoriaNome { get; set; } = string.Empty;

    public string CategoriaDescricao { get; set; } = string.Empty;
}