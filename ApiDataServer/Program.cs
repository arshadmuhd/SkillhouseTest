using ApiDataServer.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Use in memrory Db connecton//serverconnection
/*builder.Services.AddDbContext<ShopContext>(options =>
options.UseInMemoryDatabase("Shop"));*/

//db connection

builder.Services.AddDbContext<ShopContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")// connecting to appseting.json
    ));


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
