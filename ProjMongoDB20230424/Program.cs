using Microsoft.Extensions.Options;
using ProjMongoDB20230424.Config;
using ProjMongoDB20230424.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configuration Singleton and AppSeting parameters.
builder.Services.Configure<ProjMongoDbSettings>(builder.Configuration.GetSection("ProjMongoDbSettings"));
builder.Services.AddSingleton<IProjMongoDbSettings>(s => s.GetRequiredService<IOptions<ProjMongoDbSettings>>().Value);
builder.Services.AddSingleton<ClientService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
