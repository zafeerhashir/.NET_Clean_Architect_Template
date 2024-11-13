using Application.UseCases;
using Persistence;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();


// Here is di of other project will added here
builder.Services.AddInjectionPersistence();
builder.Services.AddInjectionApplication();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "EcotimeWebApi V.1");
    c.RoutePrefix = string.Empty;
});


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
