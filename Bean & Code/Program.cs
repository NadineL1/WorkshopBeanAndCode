// adding test data with a list
using Bean___Code.Data;
using Bean___Code.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

public partial class Program
{
    private static void Main(string[] args)
    {
       



        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        builder.Services.AddDbContext<BeanDbContext>(options => 
            options.UseSqlServer(builder.Configuration.GetConnectionString("Defaultconnection")));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }


        app.UseHttpsRedirection();

        app.UseAuthorization();


        // API requests for categories

        // get all categories

        app.MapGet("/categories", (BeanDbContext context) =>
        {
            return Results.Ok(context.Categories);
        });

        // get one specific category
        app.MapGet("/categories/{id}", (BeanDbContext context, int id) =>
        {
            return Results.Ok(context.Categories.FirstOrDefault(c => c.Id == id));
        });
/*
        // post, add a category
        app.MapPost("/categories", (Category category) =>
        {
            category.Id = categories.Any() ? categories.Max(c => c.Id) + 1 : 1;
            categories.Add(category);
            return Results.Ok(categories);
        });

        // delete category by id
        app.MapDelete("/categories/{id}", (int id) =>
        {
            var category = categories.FirstOrDefault(c => c.Id == id);

            if(category is null)
            {
                return Results.NotFound();
            };

            categories.Remove(category);
            return Results.Ok(category);
        });

        // API requests for products

        // get all products in list
        app.MapGet("/Products", () =>
        {
            return products;
        });

        // get one product, by id
        app.MapGet("/products/{Id}", (int Id) =>
        {
            var product = products.FirstOrDefault(p => p.Id == Id);
            return product;
        });

        // post, add product
        app.MapPost("/products", (Product product) =>
        {
            product.Id = products.Any() ? products.Max(p => p.Id) + 1 : 1;
            products.Add(product);
            return products;

        });

        // Update products
        app.MapPut("Products/{id}", (int id, Product updatedProduct) =>        {
            if (products.FirstOrDefault(p => p.Id == id) == null)
            {
                return null;
            }

            var productToBeUpdated = products.FirstOrDefault(p => p.Id == id);

            productToBeUpdated.Name = updatedProduct.Name;
            productToBeUpdated.Description = updatedProduct.Description;
            productToBeUpdated.Price = updatedProduct.Price;
            productToBeUpdated.CategoryKeyId = updatedProduct.CategoryKeyId;

            return products;
        }
        );

        // delete products 
        app.MapDelete("Products/{id}", (int id) =>
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if(product is null)
            {
                return Results.NotFound();
            }            

            products.Remove(product);
            return Results.Ok(products);
        });

        // return all products inside of a specific categor
        app.MapGet("/categories/{id}/products", (int id) => {

            var filteredProducts = products.FindAll(p => p.CategoryKeyId == id).ToList();
            return Results.Ok(filteredProducts);
        });
        */
        
        app.MapControllers();

        app.Run();
    }
}