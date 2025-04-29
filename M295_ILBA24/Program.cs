using System.Reflection;
using HotChocolate.AspNetCore;
using M295_ILBA24.Context;
using M295_ILBA24.Controllers;
using M295_ILBA24.Services;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Path = System.IO.Path;

var builder = WebApplication.CreateBuilder(args);


// Configure Serilog from appsettings.json
builder.Host.UseSerilog((context, services, configuration) =>
{
    configuration.ReadFrom.Configuration(context.Configuration)
        .Enrich.WithClassName();
});

builder.Services.AddDbContext<SakilaDbContext>(optionsBuilder =>
    optionsBuilder.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.Parse("8.1.0-mysql")
    )
);
builder.Services
    .AddGraphQLServer()
    .RegisterDbContextFactory<SakilaDbContext>()
    .AddQueryType<Query>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();


builder.Services.AddScoped<ActorService>();
builder.Services.AddScoped<AddressService>();
builder.Services.AddScoped<CityService>();
builder.Services.AddScoped<FilmService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

app.UseRouting();
app.MapGraphQL().WithOptions(new GraphQLServerOptions
    {
        Tool =
        {
            Enable = true,
            Title = "Sakila GraphQL",
            GraphQLEndpoint = "/graphql",
            ServeMode = GraphQLToolServeMode.Embedded
        }
    }
);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseAuthorization();

app.MapControllers();

app.Run();