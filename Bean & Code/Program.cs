// adding test data with a list
using Bean___Code.Models;

public partial class Program
{
    private static void Main(string[] args)
    {
        List<Product> products = new();
        List<Category> categories = new();

        categories.AddRange(
            new Category { CategoryId = 1, Name= "Varma drycker"},
            new Category{ CategoryId = 2, Name= "Kalla drycker"},
            new Category { CategoryId= 3, Name= "Bakverk"}
            );


        products.AddRange(
            new Product { ProductId= 1, Name= "Espresso", Description= "En stark italiensk kaffespecialitet", Price= 25M, CategoryKeyId= 1},
            new Product { ProductId= 2, Name= "Coffe", Description="Svart bryggt kaffe", Price= 20M, CategoryKeyId= 1},
            new Product { ProductId= 3, Name= "Latte", Description= "Mild kaffedrink med mycket mjölk", Price=40M, CategoryKeyId= 1},
            new Product { ProductId= 4, Name= "Te", Description="English breakfast", Price= 15M, CategoryKeyId= 1},
            new Product { ProductId= 5, Name= "Cheesecake", Description="En klassiker direkt från New York", Price= 45M, CategoryKeyId= 3},
            new Product { ProductId= 6, Name= "Trocadero", Description="En fruktig och kall svensk ikon", Price= 20, CategoryKeyId= 2},
            new Product { ProductId= 7, Name= "Kanelbulle", Description="Det bästa bakverket", Price=40M , CategoryKeyId=3},
            new Product { ProductId =8, Name ="Delicatoboll", Description = "Klassisk fabrikat chokladboll", Price =25M, CategoryKeyId = 3}
            );
   



        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }


        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}