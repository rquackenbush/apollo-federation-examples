using ChildSubgraph.Types;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGraphQLServer()
    .AddType<Child>()
    .AddType<Parent>()
    .AddQueryType<Query>()
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
