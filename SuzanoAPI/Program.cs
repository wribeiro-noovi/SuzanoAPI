using Microsoft.EntityFrameworkCore;
using SuzanoAPI.Contracts;
using SuzanoAPI.Repositories;
using SuzanoAPI.Repositories.DataAcess;
using SuzanoAPI.UseCase.ANI.GetStatus;
using SuzanoAPI.UseCase.Msgs_emergenciais.GetCurrent;
using SuzanoAPI.UseCase.Produtos.GetProduto;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SuzanoDbContext>(options =>
{
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IAniRepository, AniRepository>();
builder.Services.AddScoped<IMsgEmergencialRepository, MsgEmergencialRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<ClienteRepository>();

builder.Services.AddScoped<GetStatusUseCase>();
builder.Services.AddScoped<GetCurretUseCase>();
builder.Services.AddScoped<GetProdutoUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
    app.UseSwagger();
    app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
