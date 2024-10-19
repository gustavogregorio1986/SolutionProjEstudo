using Microsoft.EntityFrameworkCore;
using SolutioProEstudo.Data.AutoMapper;
using SolutioProEstudo.Data.Contexto;
using SolutioProEstudo.Data.Repository;
using SolutioProEstudo.Data.Repository.Inetrface;
using SolutioProEstudo.Servico.Servico;
using SolutioProEstudo.Servico.Servico.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SolutioProjEstudoContxto>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
builder.Services.AddScoped<IEmpresaRepository, EmpresaRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

builder.Services.AddScoped<IClienteServico, ClienteServico>();
builder.Services.AddScoped<IEmpresaServico, EmpresaServico>();
builder.Services.AddScoped<IFuncionarioServico, FuncionarioServico>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
