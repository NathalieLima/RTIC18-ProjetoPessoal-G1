namespace Escambo.Domain.Entities;
public class PrestacaoServico
{
    public int PrestacaoServicoId { get; set; }
    ICollection<Usuario>? Usuarios { get; set; }
}
