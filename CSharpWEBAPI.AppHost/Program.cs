using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CSharpWEBAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços MVC (controladores)
builder.Services.AddControllers();

// Adiciona o ProdutoService como um serviço singleton
builder.Services.AddSingleton<ProdutoService>();

builder.Services.AddControllers();

// ⬇️ Adiciona suporte ao Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configura o pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
// ⬇️ Habilita o Swagger apenas em ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
