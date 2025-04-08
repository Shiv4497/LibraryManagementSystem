using LibraryManagement.API.Database;
using LibraryManagement.API.Database.Repositories;
using LibraryManagement.API.Services.Implementations.Services;
using LibraryManagement.API.Services.Interfaces.Repositories;
using LibraryManagement.API.Services.Interfaces.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
string connString = builder.Configuration.GetConnectionString("LibraryManagementDB");
builder.Services.AddDbContext<LibraryManagementDbContext>(options => options.UseSqlServer(connString));
builder.Services.AddScoped<IAuthorRepository, AuthorsRepository>();
builder.Services.AddScoped<IAuthorsService, AuthorsService>();

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
