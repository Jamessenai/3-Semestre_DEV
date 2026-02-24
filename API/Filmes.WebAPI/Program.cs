using Filmes.WebAPI.BdContextFilme;
using Filmes.WebAPI.Interfaces;
using Filmes.WebAPI.Repositorys;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FilmeContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IGeneroRepositorys, GeneroRepositorys>();
builder.Services.AddScoped<IFilmeRepository, FilmeRepositorys>();

builder.Services.AddControllers();

var app = builder.Build();


app.Run();
