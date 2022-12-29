using EscuelaPrueba.Core.Interface;
using EscuelaPrueba.Infraestructure.Data;
using EscuelaPrueba.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IEstudiantesRepository, EstudianteRepository>();

builder.Services.AddTransient<ICusosRepository, CursoRepository>();

builder.Services.AddTransient<IProfesorRepository, ProfesorRepository>();

builder.Services.AddDbContext<EscuelaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EscuelaPrueba"))
);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
