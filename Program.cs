using API_Filmes_SENAI.Context;
using API_Filmes_SENAI.Interfaces;
using API_Filmes_SENAI.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o contexto do banco de dados (exemplo com SQL Server)
builder.Services.AddDbContext<Filmes_Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//adicionar o rep�sitorio e a interface ao container de inje��o de dep�ndencia
builder.Services.AddScoped<IGeneroRepository, GeneroReposity>();
builder.Services.AddScoped<IFilmeRepository, FilmeRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();


//adicionar o servi�o de Controllers
builder.Services.AddControllers();

var app = builder.Build();

//adicionar o mapeamento dos controllers
app.MapControllers();

app.Run();
