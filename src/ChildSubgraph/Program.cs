using ChildSubgraph.Types;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGraphQLServer()
    .AddType<Child>()
    .AddQueryType<Query>()
    .AddTypeExtension<Parent>()
    .AddApolloFederationV2();

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

var app = builder.Build();

app.UseCors();

app.MapGraphQL();

app.Run();
