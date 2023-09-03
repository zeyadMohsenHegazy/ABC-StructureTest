using Microsoft.EntityFrameworkCore;
using Models.models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer("Data Source=.; Initial Catalog=ABC_New; Integrated Security=true; TrustServerCertificate=true");
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");


app.Run();
