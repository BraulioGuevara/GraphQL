using GraphAPI.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGraphQLServer().AddQueryType<SerieQuery>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
