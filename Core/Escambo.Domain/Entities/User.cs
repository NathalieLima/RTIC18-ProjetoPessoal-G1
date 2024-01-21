namespace Escambo.Domain.Entities;
public sealed class User: BaseEntity 
{
    public string? Name { get; set; } //nome
    public required string? Email{get;set;} //email
    public required string Password { get; set; } //senha
    public required string? CPF {get; set;}
    public required string? RG {get; set;}
    public DateTime Birth {get;set;} //aniversario
    public string? Address {get; set;} //endereço
    public int Status {get;set;} 
    public decimal Credit {get;set;} //credito

}
