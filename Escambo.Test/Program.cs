using Escambo.Domain.Entities;
using Escambo.Pesistence.Context;

var context = new EscamboContext();

// Remover dados antigos
context.Users.RemoveRange(context.Users);
context.Advertisement.RemoveRange(context.Advertisement);
context.Services.RemoveRange(context.Services);
context.Chats.RemoveRange(context.Chats);
context.Messages.RemoveRange(context.Messages);
context.Posters.RemoveRange(context.Posters);
context.Avaluations.RemoveRange(context.Avaluations);

// Salvar alterações
context.SaveChanges();

Console.WriteLine($"Popular banco de dados");

#region Dados para o banco de dados

/* PARTE 1: USUÁRIOS SE DEFINEM COMO PRESTADORES E/OU CONTRATADORES */

// Usuario1: contratante, quem precisa do serviço
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

// Definição do serviço solicitado do usuario1
var serviceInstance = new Service {
    ServiceId = 1,
    Description = "Design de logotipo",
    Category = "Design",
    Type = "Logotipo",
    Status = 0,
    Duration = "2 horas",
    WorkDate = DateTime.Now,
    CreditOffer = 50,
    UserIdRequired = 1,
    UserRequired = usuario1,
};

// Usuario2: prestador, quem fará o serviço
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

// Anúncio de usuario2
var advertisementInstance = new Advertisement {
    AdvertisementId = 1,
    Name = "Design de logotipo",
    Description = "Precisando de um logotipo personalizado para o seu negócio? Contate-me!",
    Credit = 50,
    Category = "Design",
    Type = "Logotipo",
    User = usuario2,
    UserId = 2
};

usuario2.Advertisements.Add(advertisementInstance);

/* PARTE 2: PRESTADOR E CONTRATADOR ENTRAM EM CONTATO */

var chatInstance = new Chat
{
    ChatId = 1,
    BeginDate = DateTime.Now.AddHours(-1),
    EndDate = DateTime.Now,
    SenderId = 2,
    Sender = usuario2,
    ReceiverId = 1,
    Receiver = usuario1
};

var message1 = new Message
{
    MessageId = 1,
    Text = "Olá, podemos discutir detalhes?",
    SendDate = DateTime.Now,
    ChatId = 2,
    Chat = chatInstance
};

var message2 = new Message
{
    MessageId = 2,
    Text = "Ansioso para trabalhar.",
    SendDate = DateTime.Now,
    ChatId = 2,
    Chat = chatInstance
};

chatInstance.Messages.Add(message1);
chatInstance.Messages.Add(message2);

/* PARTE 3 : O SERVIÇO É FECHADO ENTRE AMBOS OS USUÁRIOS */

serviceInstance.UserIdAccepted = 2;
serviceInstance.UserAccepted = usuario2;

var posterInstance = new Poster
{
    PosterId = 1,
    UserId = 1,
    User = usuario1,
    ServiceId = 1,
    Service = serviceInstance
};

/* PARTE 4: AVALIAÇÃO DO SERVIÇO APÓS SUA FINALIZAÇÃO */

var avaluationInstance = new Avaluation
{
    AvaluationId = 1, 
    PosterId = 1,
    Poster = posterInstance,
    AvaliadorId = 1,
    Avaliador = usuario1,
    AvaliadoId = 2,
    Avaliado = usuario2,
    Star = 5,
    Comment = "Ótimo trabalho!",
};

usuario1.AvaluationsAsAvaluator.Add(avaluationInstance);
usuario2.AvaluationsAsAvaluated.Add(avaluationInstance);

#endregion

#region Adicionar dados e enviá-los

context.Users.AddRange(usuario1, usuario2);
context.Advertisement.Add(advertisementInstance);
context.Services.Add(serviceInstance);
context.Chats.Add(chatInstance);
context.Messages.AddRange(message1, message2);
context.Posters.Add(posterInstance);
context.Avaluations.Add(avaluationInstance);

context.SaveChanges();

#endregion


Console.WriteLine($"Finalizando o programa");