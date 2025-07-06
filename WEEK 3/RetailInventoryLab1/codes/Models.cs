using System.Collections.Generic;

public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; }

    public List<Product> Products { get; set; } = new();
}

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
