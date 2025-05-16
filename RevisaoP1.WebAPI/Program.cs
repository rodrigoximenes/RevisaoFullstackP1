using Microsoft.EntityFrameworkCore;
using RevisaoP1.Repositorio;
using RevisaoP1.Servico;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("AlunosDb"));
builder.Services.AddScoped<IAlunoRepositorio, AlunoRepositorio>();
builder.Services.AddScoped<IAlunoServico, AlunoServico>();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost4200",
     policy =>
     {
         policy.WithOrigins("http://localhost:4200")
     .AllowAnyHeader()
     .AllowAnyMethod();
     });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Use o CORS antes do MapControllers
app.UseCors("AllowLocalhost4200");

app.MapControllers();

app.Run();
