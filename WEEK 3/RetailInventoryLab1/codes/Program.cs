using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        using var context = new RetailContext();

        // Create DB if not exists
        context.Database.EnsureCreated();

        // Add seed data if DB is empty
        if (!context.Categories.Any())
        {
            var electronics = new Category { Name = "Electronics" };
            electronics.Products.Add(new Product { Name = "Laptop", Quantity = 10 });
            electronics.Products.Add(new Product { Name = "Mouse", Quantity = 50 });

            var groceries = new Category { Name = "Groceries" };
            groceries.Products.Add(new Product { Name = "Apples", Quantity = 30 });

            context.Categories.AddRange(electronics, groceries);
            context.SaveChanges();
        }

        // Show all products
        var products = context.Products.Include(p => p.Category).ToList();
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Name} ({p.Category.Name}) - Qty: {p.Quantity}");
        }
    }
}
