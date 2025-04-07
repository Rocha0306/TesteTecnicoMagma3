using BackEnd.Infrastructure;
using BackEnd.Middlewares;
using BackEnd.Repository;
using AutoMapper;
using BackEnd.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.Dependencies(); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddSingleton<IMongoRepository, MongoRepository>();
builder.Services.AddSingleton<ITokenService, TokenService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.MapControllers(); 
app.UseMiddleware<ExceptionalHandler>();

app.Run();


