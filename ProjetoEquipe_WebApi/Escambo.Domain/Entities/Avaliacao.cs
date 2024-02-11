namespace Escambo.Domain.Entities;
public class Avaliacao
{

    public int AvaliacaoId { get; set; }
    public string? Descricao { get; set; }
    public int Nota { get; set; } //estrelas de 1 a 5 de 0 a 10;
    public int PrestacaoServicoId { get; set; }
    public PrestacaoServico? PrestacaoServico { get; set; }
    
    public int UsuarioId { get; set; }
    public Usuario? Usuario { get; set; }
}  
