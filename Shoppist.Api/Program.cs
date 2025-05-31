using Shoppist.Api.Endpoints;
using Shoppist.Persistence;
using static Microsoft.AspNetCore.Builder.WebApplication;

var builder = CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddPersistence(builder.Configuration.GetConnectionString("Sqlite"));
WebApplication app = builder.Build(); 

if (app.Environment.IsDevelopment())
    app.MapOpenApi();

app.UseHttpsRedirection();

app.MapInfoEndpoints();
app.MapItemEndpoints();

app.Run();
