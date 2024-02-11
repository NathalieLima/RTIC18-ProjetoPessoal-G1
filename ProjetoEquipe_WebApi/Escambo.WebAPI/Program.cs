using Escambo.Application.Services;
using Escambo.Application.Services.Interface;
using Escambo.Infra.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
 



// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddDbContext<EscamboContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("Escambo");
    var serveVersion = ServerVersion.AutoDetect(connectionString);
    options.UseMySql(connectionString, serveVersion);

});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.Run();
