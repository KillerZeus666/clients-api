using ClientesApi.Data;
using ClientesApi.Repositories;
using ClientesApi.Services;
using Microsoft.EntityFrameworkCore;
using ClientesApi.Models;

var builder = WebApplication.CreateBuilder(args);

// DB en memoria
builder.Services.AddDbContext<ClientesContext>(opt =>
    opt.UseInMemoryDatabase("ClientesDB"));

// Inyección de dependencias
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<ClienteService>();

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

// Datos iniciales
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ClientesContext>();

    context.Clientes.AddRange(
        new Cliente { Nombre = "Ana", Correo = "ana@mail.com" },
        new Cliente { Nombre = "Luis", Correo = "luis@mail.com" }
    );

    context.SaveChanges();
}

app.Run();