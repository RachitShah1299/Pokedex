using Microsoft.OpenApi.Models;
using Pokedex.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Pokedex.Api", Version = "v1" });
});

builder.Services.AddHttpClient();
builder.Services.AddScoped<IPokemonService, PokemonService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Pokedex.Api v1"));
    app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
