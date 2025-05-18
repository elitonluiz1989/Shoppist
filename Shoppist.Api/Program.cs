using Shoppist.Api.Endpoints;
using static Microsoft.AspNetCore.Builder.WebApplication;

WebApplicationBuilder builder = CreateBuilder(args);

builder.Services.AddOpenApi();

WebApplication app = builder.Build(); 

if (app.Environment.IsDevelopment())
    app.MapOpenApi();

app.UseHttpsRedirection();

ApiInfoEndpoints.Map(app);

app.Run();
