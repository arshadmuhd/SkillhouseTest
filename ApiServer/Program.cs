using Ap1.Data;
using Ap1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);




// Add services to the container.

builder.Services.AddControllers();




    //Model state invalid Error handler
  /*  .ConfigureApiBehaviorOptions(options =>
    {
        options.
        SuppressModelStateInvalidFilter = true;
    });*/



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//Use in memrory Db connecton
/*builder.Services.AddDbContext<ShopContext>(options =>
options.UseInMemoryDatabase("Shop"));*/


//Use in memrory Db connecton//serverconnection
builder.Services.AddDbContext<ShopContext>(options =>
options.UseInMemoryDatabase("Shop"));




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
