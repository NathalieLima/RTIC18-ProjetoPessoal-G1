using Escambo.Domain.Entities;
using Escambo.Pesistence.Context;

var context = new EscamboContext();

// Remover dados antigos
context.Users.RemoveRange(context.Users);

// Salvar alterações
context.SaveChanges();

Console.WriteLine($"Popular banco de dados");

#region Dados para o banco de dados

var usuario1 = new User {
    UserId = 1,
    Name = "Náthalie",
    Email = "usuario1@example.com",
    Password = "senha123",
    CPF = "123.456.789-01",
    RG = "1234567",
    Birth = new DateTime(1990, 5, 15),
    Address = "Rua A, 123",
    Status = 1,
    Credit = 100
};

var usuario2 = new User {
    UserId = 2,
    Name = "Gabriel",
    Email = "usuario2@example.com",
    Password = "senha456",
    CPF = "987.654.321-01",
    RG = "7654321",
    Birth = new DateTime(1985, 10, 20),
    Address = "Rua B, 456",
    Status = 1,
    Credit = 80
};

#endregion

#region Adicionar dados e enviá-los

context.Users.AddRange(usuario1, usuario2);
context.SaveChanges();

#endregion


Console.WriteLine($"Finalizando o programa");