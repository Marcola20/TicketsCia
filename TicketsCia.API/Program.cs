global using TicketsCia.Models;
using Microsoft.EntityFrameworkCore;
using TicketsCia.API.Database;
using TicketsCia.API.Repositories;

var builder = WebApplication.CreateBuilder(args);

#region Configure Service
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TicketsCiaContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("TicketsCia"))
);

builder.Services.AddScoped<ITicketRepository, TicketRepository>();
#endregion

var app = builder.Build();

#region Configure
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
#endregion