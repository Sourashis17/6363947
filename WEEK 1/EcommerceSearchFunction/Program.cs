using System;
using System.Linq;

namespace EcommerceSearchFunction
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }

        public Product(int id, string name, string category)
        {
            ProductId = id;
            ProductName = name;
            Category = category;
        }

        public override string ToString()
        {
            return $"ID: {ProductId}, Name: {ProductName}, Category: {Category}";
        }
    }

    class Program
    {
        // Linear Search
        static Product? LinearSearch(Product[] products, string targetName)
        {
            foreach (var product in products)
            {
                if (product.ProductName.Equals(targetName, StringComparison.OrdinalIgnoreCase))
                    return product;
            }
            return null;
        }

        // Binary Search
        static Product? BinarySearch(Product[] products, string targetName)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int comparison = string.Compare(products[mid].ProductName, targetName, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                    return products[mid];
                if (comparison < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return null;
        }

        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Shoes", "Fashion"),
                new Product(3, "Smartphone", "Electronics"),
                new Product(4, "Watch", "Accessories"),
                new Product(5, "Book", "Education")
            };

            Console.WriteLine("Linear Search:");
            var result1 = LinearSearch(products, "Watch");
            Console.WriteLine(result1 != null ? result1.ToString() : "Product not found.");

            Console.WriteLine("\nBinary Search:");
            var sortedProducts = products.OrderBy(p => p.ProductName).ToArray();
            var result2 = BinarySearch(sortedProducts, "Watch");
            Console.WriteLine(result2 != null ? result2.ToString() : "Product not found.");
        }
    }
}
