using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        using var db = new RetailContext();

        // Ensure DB and tables are created (usually already done via migration)
        db.Database.EnsureCreated();

        // Insert sample data if not already there
        if (!db.Categories.Any())
        {
            var electronics = new Category { Name = "Electronics" };
            electronics.Products.Add(new Product { Name = "Phone", Price = 20000 });
            electronics.Products.Add(new Product { Name = "Tablet", Price = 30000 });

            var grocery = new Category { Name = "Grocery" };
            grocery.Products.Add(new Product { Name = "Milk", Price = 60 });

            db.Categories.AddRange(electronics, grocery);
            db.SaveChanges();
        }

        // Display all products with their category
        var products = db.Products.Include(p => p.Category).ToList();
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Name} - ₹{p.Price} ({p.Category.Name})");
        }
    }
}
