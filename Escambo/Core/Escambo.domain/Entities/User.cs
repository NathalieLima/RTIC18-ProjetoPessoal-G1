namespace Escambo.domain.Entities;
public sealed class User: BaseEntity 
{
    public string? Name { get; set; } //nome
    public string? Email{get;set;} //email
    public string? Password { get; set; } //senha
    public string? CPF {get; set;}
    public string? RG {get; set;}
    public DateTime Birth {get;set;} //aniversario
    public string? Address {get; set;} //endereço
    public int Status {get;set;} 
    public decimal Credit {get;set;} //credito

}
