using RelationshipSubgraph.Data;
using RelationshipSubgraph.Types;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddGraphQLServer()
    .RegisterService<RelationshipRepository>()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
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

builder.Services.AddSingleton<RelationshipRepository>();

var app = builder.Build();

app.UseCors();

app.MapGraphQL();

app.Run();

