using WerkurenCounterCsharp_api.Repositories;
using WerkurenCounterCsharp_api.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepo,MysqlRepo>();

String _connectionString = builder.Configuration["ConnectionString:MySqlConnection"];
Console.WriteLine(_connectionString);

builder.Services.AddDbContext<WorkDayContext>(opt => opt.UseMySql(_connectionString,ServerVersion.AutoDetect(_connectionString)));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
