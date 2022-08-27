using CatalogoCurso.Application;
using CatalogoCurso.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services
    .RegisterApplication()
    .RegisterRepository(builder.Configuration.GetConnectionString("CatalogoCurso"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
