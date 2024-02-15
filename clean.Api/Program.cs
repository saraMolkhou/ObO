using clean.core.Repositories;
using clean.Data;
using clean.Data.Repository;
using clean.services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<customerServies>();
builder.Services.AddScoped<ICustomerRepository, customerRepository>();
builder.Services.AddDbContext<DataContext>();

builder.Services.AddScoped<productServies>();
builder.Services.AddScoped<IProductRepository, productRepository>();
builder.Services.AddDbContext<DataContext>();

builder.Services.AddScoped<orderServies>();
builder.Services.AddScoped<IOrderRepository, orderRepository>();
builder.Services.AddDbContext<DataContext>();

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
