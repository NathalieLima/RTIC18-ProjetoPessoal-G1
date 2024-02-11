namespace  Escambo.Application.Model.ViewInput;
public class UsuarioViewInputModel{

    public string? Nome { get; set; }
    public string? Email { get; set; }  
    public string? CPF {get;set;}
    public string? Telefone {get;set;}
    public EnderecoViewInputModel? Endereco {get;set;}
    public LoginViewInputModel? Login { get; set; }
   
}
