namespace Escambo.WebAPI.Model;
public class Usuario
{
    public int UsuarioId { get; set; }
    public required string Nome { get; set; }
    public required string Login { get; set; }
    public required string Senha { get; set; }
    public required string Email { get; set; }
    public required string CPF { get; set; }
    public required short status { get; set; }
    public required string RG { get; set; }
    public required string Endereco { get; set; }
    public required DateOnly DataNascimento { get; set; }
    public required float Credito { get; set; }
    public string? LinkLinkedin { get; set; }
    public string? Sobre { get; set; }

    //public ICollection<Conversa>? Conversas {get;set;}    
    //public ICollection<Anuncio>? Anuncios {get;set;}    
    //public ICollection<Prestacao>? Prestacaos {get;set;}    
}