namespace Biblioteca.Domain.Entities;

public class Usuario
{
    public int UsuarioId { get; set; }

    public string UsuarioNome { get; set; } = string.Empty;

    public string UsuarioEmail { get; set; } = string.Empty;

    public string UsuarioCpf { get; set; } = string.Empty;
}