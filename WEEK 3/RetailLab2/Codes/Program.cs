using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        using var context = new AppDbContext();

        // Seed data if empty
        if (!context.Categories.Any())
        {
            var clothing = new Category { Name = "Clothing" };
            clothing.Products.Add(new Product { Name = "Shirt", Price = 799 });
            clothing.Products.Add(new Product { Name = "Jeans", Price = 1299 });

            var grocery = new Category { Name = "Grocery" };
            grocery.Products.Add(new Product { Name = "Milk", Price = 60 });

            context.Categories.AddRange(clothing, grocery);
            context.SaveChanges();
        }

        // Show all products
        var products = context.Products.Include(p => p.Category).ToList();
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Name} - ₹{p.Price} ({p.Category.Name})");
        }
    }
}
