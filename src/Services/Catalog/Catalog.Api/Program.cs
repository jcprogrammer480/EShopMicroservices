var builder = WebApplication.CreateBuilder(args);
//Add services to the container

var app = builder.Build();
//Add API End points and middleware stuff

app.Run();
