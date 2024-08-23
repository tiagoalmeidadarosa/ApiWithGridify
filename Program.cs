using ApiWithGridify.Repository;
using ApiWithGridify.Services;
using Gridify;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/products", ([AsParameters] GridifyQuery gridifyQuery, [FromServices] IProductService productService) =>
{
    var products = productService.GetFilteredProducts(gridifyQuery);
    return products;
})
.WithName("GetProducts")
.WithOpenApi();

await app.RunAsync();
