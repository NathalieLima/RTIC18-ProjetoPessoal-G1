namespace Escambo.Domain.Entities;
public class Anucio{

    public int AnuncioId { get; set;}
    public string? Texto { get; set;}


    public int UsuarioId { get; set;} 
    public required  Usuario Usuario { get; set;}


    public int PrestacaoServicoId { get; set;}
    public required PrestacaoServico PrestacaoServico { get; set;}
}
