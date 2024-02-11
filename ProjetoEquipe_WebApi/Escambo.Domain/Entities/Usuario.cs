using System.Runtime.InteropServices;

namespace Escambo.Domain.Entities;
public class Usuario
{
    public int UsuarioId { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }  
    public string? CPF {get;set;}
    public string? Telefone {get;set;}
   
    public int EnderecoId {get;set;}
    public Endereco? Endereco {get;set;}

    public int LoginId { get; set; }
    public Login? Login { get; set; }

    public ICollection<Chat>? Chats { get; set; }
    public ICollection<Anucio>? Anucios { get; set; }
    public ICollection<PrestacaoServico>? PrestacaoServicos { get; set; }
    public ICollection<Avaliacao>? Avaliacoes { get; set; }
}
