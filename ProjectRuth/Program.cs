using Microsoft.EntityFrameworkCore;
using ProjectRuth.Config;
using Subscribere_Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigurationManager configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.ConfigureServices();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(opt => opt.AddPolicy("MyPolicy", policy =>
{
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));


builder.Services.AddDbContext<Weight_WatchersContext>(option =>
{
    ///הגדרתי לאיזה DB להתחבר 
    option.UseSqlServer(configuration.GetConnectionString("ProjectRuthConnectionString"));
}
       );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//app.UseCors(builder =>
//{
//    builder
//    .AllowAnyOrigin()
//    .AllowAnyMethod()
//    .AllowAnyHeader();
//});
app.UseCors("MyPolicy");
app.MapControllers();
//לעוד מעט....////
app.UseMiddleware(typeof(ErrorHandlingMiddleware));

app.Run();
