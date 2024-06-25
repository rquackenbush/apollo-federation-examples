using FooSubgraph.Data;
using FooSubgraph.Types;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddGraphQLServer()
    .AddApolloFederationV2()
    .RegisterService<FooRepository>()
    .AddQueryType<Query>();


builder
   .Services
   .AddCors(options =>
   {
       options.AddDefaultPolicy(builder =>
       {
           builder
               .WithOrigins("https://studio.apollographql.com")
               .AllowAnyHeader()
               .AllowAnyMethod();
       });
   });

builder.Services.AddSingleton<FooRepository>();

var app = builder.Build();

app.UseCors();

app.MapGraphQL();

app.Run();

